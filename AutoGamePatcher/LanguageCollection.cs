namespace AutoGamePatcher
{
    public static class LanguageCollection
    {

        private static Language[] all;

        public static Language[] All
        {
            get
            {
                return (Language[])all.Clone();
            }
        }

        static LanguageCollection()
        {
            all = new Language[] { new Language("ENGLISH", "en-GB"), new Language("GERMAN", "de-DE") };
        }
    }
}
