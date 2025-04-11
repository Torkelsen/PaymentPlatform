namespace PaymentPlatform.Constants;

public static class PaymentProviders
{
    public static readonly Guid Stripe = Guid.Parse("11111111-1111-1111-1111-111111111111");
    public static readonly Guid Strex = Guid.Parse("22222222-2222-2222-2222-222222222222");
    public static readonly Guid Vipps = Guid.Parse("33333333-3333-3333-3333-333333333333");

    // Optional: Helper method to check if a GUID is a valid provider
    public static bool IsValidProvider(Guid providerId) =>
        providerId == Stripe ||
        providerId == Strex ||
        providerId == Vipps;
} 