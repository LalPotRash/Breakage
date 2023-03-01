namespace Breakage.Data
{
    public partial class BreakageDaniilEntities
    {
        private static BreakageDaniilEntities _context;
        public static BreakageDaniilEntities GetContext()
        {
            if( _context == null )
                _context = new BreakageDaniilEntities();

            return _context;
        }
    }
}
