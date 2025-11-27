# Architecture Overview - OOP Design Playground

This document explains the high-level architecture and relationships.

## Components
- **Core.Logging**: ILogger, ConsoleLogger
- **Core.Notifications**: INotifier, EmailNotifier, SmsNotifier
- **Core.Payments**: IPaymentGateway, PaymentProcessor, ZarinPalGateway, SepGateway
- **Models**: PaymentRequest, PaymentResult
- **Services**: CheckoutService (orchestrates payment and notification)

## Flow (Checkout)
1. CheckoutService receives PaymentRequest and notifier/recipient.
2. CheckoutService calls IPaymentGateway.ChargeAsync(request).
3. Gateway processes and returns PaymentResult.
4. If success → notifier.Send(...) and logger logs success; else logs failure and notifies.