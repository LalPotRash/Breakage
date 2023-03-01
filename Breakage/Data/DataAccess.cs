using System.Linq;
using System.Collections.Generic;
using System.Windows;

namespace Breakage.Data
{
    public class DataAccess
    {
        public delegate void RefreshListDelegate();
        public static event RefreshListDelegate RefreshList;

        public static List<Client> GetClients()
        {
            return BreakageDaniilEntities.GetContext().Clients.ToList();
        }

        public static List<Service> GetServices()
        {
            return BreakageDaniilEntities.GetContext().Services.ToList();
        }

        public static List<Gender> GetGenders()
        {
            return BreakageDaniilEntities.GetContext().Genders.ToList();
        }

        public static void SaveClient(Client client)
        {
            if (client.ID == 0)
                BreakageDaniilEntities.GetContext().Clients.Add(client);

            try
            {
                BreakageDaniilEntities.GetContext().SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения!");
            }

            RefreshList?.Invoke();
        }

        public static void DeleteClient(Client client)
        {
            try
            {
                BreakageDaniilEntities.GetContext().Clients.Remove(client);
                BreakageDaniilEntities.GetContext().SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!");
            }

            RefreshList?.Invoke();
        }
    }
}
