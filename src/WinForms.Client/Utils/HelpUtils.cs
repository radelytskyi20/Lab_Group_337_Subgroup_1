namespace WinForms.Client.Utils
{
    public static class HelpUtils
    {
        private static readonly string _helpPath = "D:\\Университет\\3 КУРС 2 СЕМЕСТР\\Технологии создания программ(Момот)\\Labs\\help\\Lab3Docs.chm";

        public static void ShowHelp(Control parent, string topic)
        {
            if (!File.Exists(_helpPath))
            {
                MessageBox.Show("Doc file not found!");
                return;
            }

            Help.ShowHelp(parent, _helpPath, HelpNavigator.Topic, topic);
        }
    }
}
