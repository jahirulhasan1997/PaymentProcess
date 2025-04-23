# PaymentProcess

Design used :
1. Payment Strategy : To choose the appropriate payment method.
2. Payment factory : To retrive the payment streagy from the factory.
3. Dependency Injection : To use different services without depending on the services. we can add as many payment methods.

Why these patterns :
Stretegy pattern : to encapsulate different payment methods (CreditCard, PayPal, Crypto, etc.) behind a common interface.
Factory Pattern – to instantiate the appropriate strategy based on runtime input without modifying client code.

Scalability :
We can add as many payment methods without modifying large code. We can add a payment strategy by implementing base strategy and initialiaze the service in program.cs.
