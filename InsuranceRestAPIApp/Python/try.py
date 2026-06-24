class Event:
    def __init__(self):
        self.handlers = []

    def subscribe(self, handler):
        self.handlers.append(handler)

    def unsubscribe(self, handler):
        self.handlers.remove(handler)  

    def notify(self, *args, **kwargs):
        for handler in self.handlers:
            handler(*args, **kwargs)


class PolicyEventArgs:
    def __init__(self, policy_id, customer_name):
        self.policy_id = policy_id
        self.customer_name = customer_name


class PolicyService:

    def __init__(self):

        self.policy_purchased = Event()
        self.premium_paid = Event()
        self.claim_registered = Event()
        self.policy_expired = Event()

    def purchase_policy(self, policy_id, customer_name):

        print(f"\nPolicy Purchased : {policy_id}")

        event_args = PolicyEventArgs(
            policy_id,
            customer_name
        )

        self.policy_purchased.notify(event_args)

    def pay_premium(self, policy_id, customer_name):

        print(f"\nPremium Paid : {policy_id}")

        event_args = PolicyEventArgs(
            policy_id,
            customer_name
        )

        self.premium_paid.notify(event_args)

    def register_claim(self, policy_id, customer_name):

        print(f"\nClaim Registered : {policy_id}")

        event_args = PolicyEventArgs(
            policy_id,
            customer_name
        )

        self.claim_registered.notify(event_args)

    def expire_policy(self, policy_id, customer_name):

        print(f"\nPolicy Expired : {policy_id}")

        event_args = PolicyEventArgs(
            policy_id,
            customer_name
        )

        self.policy_expired.notify(event_args)


class SalesDepartment:

    def handle_policy_purchase(self, event_args):

        print(
            f"Sales Department : "
            f"New Policy Sold To "
            f"{event_args.customer_name}"
        )


class AccountsDepartment:

    def handle_premium_payment(self, event_args):

        print(
            f"Accounts Department : "
            f"Premium Received For "
            f"{event_args.policy_id}"
        )


class ClaimDepartment:

    def handle_claim_registration(self, event_args):

        print(
            f"Claim Department : "
            f"Claim Registered For "
            f"{event_args.policy_id}"
        )


class RenewalDepartment:

    def handle_policy_expiry(self, event_args):

        print(
            f"Renewal Department : "
            f"Renewal Reminder Sent For "
            f"{event_args.policy_id}"
        )


class EmailNotificationService:

    def send_purchase_email(self, event_args):

        print(
            f"Email Service : "
            f"Purchase Confirmation Sent To "
            f"{event_args.customer_name}"
        )

    def send_claim_email(self, event_args):

        print(
            f"Email Service : "
            f"Claim Confirmation Sent For "
            f"{event_args.policy_id}"
        )


class SMSNotificationService:

    def send_sms(self, event_args):

        print(
            f"SMS Service : "
            f"Notification Sent For "
            f"{event_args.policy_id}"
        )


class AuditService:

    def log_event(self, event_args):

        print(
            f"Audit Service : "
            f"Logged Activity For "
            f"{event_args.policy_id}"
        )


# Main Program
import sys


def setup_policy_service():
    policy_service = PolicyService()

    sales_department = SalesDepartment()
    accounts_department = AccountsDepartment()
    claim_department = ClaimDepartment()
    renewal_department = RenewalDepartment()

    email_service = EmailNotificationService()
    sms_service = SMSNotificationService()
    audit_service = AuditService()

    # Policy Purchased Event Subscribers
    policy_service.policy_purchased.subscribe(
        sales_department.handle_policy_purchase
    )
    policy_service.policy_purchased.subscribe(
        email_service.send_purchase_email
    )
    policy_service.policy_purchased.subscribe(
        sms_service.send_sms
    )
    policy_service.policy_purchased.subscribe(
        audit_service.log_event
    )

    # Premium Paid Event Subscribers
    policy_service.premium_paid.subscribe(
        accounts_department.handle_premium_payment
    )
    policy_service.premium_paid.subscribe(
        sms_service.send_sms
    )
    policy_service.premium_paid.subscribe(
        audit_service.log_event
    )

    # Claim Registered Event Subscribers
    policy_service.claim_registered.subscribe(
        claim_department.handle_claim_registration
    )
    policy_service.claim_registered.subscribe(
        email_service.send_claim_email
    )
    policy_service.claim_registered.subscribe(
        audit_service.log_event
    )

    # Policy Expired Event Subscribers
    policy_service.policy_expired.subscribe(
        renewal_department.handle_policy_expiry
    )
    policy_service.policy_expired.subscribe(
        sms_service.send_sms
    )
    policy_service.policy_expired.subscribe(
        audit_service.log_event
    )

    return policy_service


def prompt_policy_info():
    policy_id = input("Enter Policy ID: ").strip()
    customer_name = input("Enter Customer Name: ").strip()
    return policy_id, customer_name


def run_demo(policy_service):
    policy_service.purchase_policy("POL101", "Yash")
    policy_service.pay_premium("POL101", "Yash")
    policy_service.register_claim("POL101", "Yash")
    policy_service.expire_policy("POL101", "Yash")


def main():
    policy_service = setup_policy_service()

    print("Insurance Events Console")

    while True:
        print("\nMenu:")
        print("1. Purchase Policy")
        print("2. Pay Premium")
        print("3. Register Claim")
        print("4. Expire Policy")
        print("5. Demo (run sample flow)")
        print("6. Exit")

        choice = input("Choose an option [1-6]: ").strip()

        if choice == "1":
            pid, name = prompt_policy_info()
            policy_service.purchase_policy(pid, name)
        elif choice == "2":
            pid, name = prompt_policy_info()
            policy_service.pay_premium(pid, name)
        elif choice == "3":
            pid, name = prompt_policy_info()
            policy_service.register_claim(pid, name)
        elif choice == "4":
            pid, name = prompt_policy_info()
            policy_service.expire_policy(pid, name)
        elif choice == "5":
            run_demo(policy_service)
        elif choice == "6":
            print("Goodbye.")
            break
        else:
            print("Invalid choice, try again.")


if __name__ == "__main__":
    # Allow non-interactive demo mode for quick tests: `python insurance_events.py demo`
    if len(sys.argv) > 1 and sys.argv[1].lower() == "demo":
        ps = setup_policy_service()
        run_demo(ps)
    else:
        try:
            main()
        except (KeyboardInterrupt, EOFError):
            print("\nExiting.")