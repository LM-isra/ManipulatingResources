namespace ManipulatingResources.Api.Helpers.Enumerations
{
    public static class NomenclatureTables
    {
        public enum AccountType { Stream = 1, Credit = 2 };
        public enum Coin { MexicanPeso = 1, AmericanDollar = 2, Euro = 3 };
        public enum MovementType { Opening = 1, Deposit = 2, Retirement = 3, Interests = 4, Check = 5, Transfer = 6 };
        public enum Status { Disabled = 1, Activated = 2 };
    }
}
