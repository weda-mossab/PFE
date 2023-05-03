namespace NEURONFACMOD.Server.Data
{
    public class DataCOntext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){
            
        }
    }
}