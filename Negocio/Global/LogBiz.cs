using Infraestrutura.DataBaseFactory;
using Infraestrutura.Entidades.Log;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Negocio.Global
{
    public class LogBiz
    {
        public LogBiz(string tela, string evento, int idCliente, int? idUsuario = null)
        {
            SalvarLog(tela, evento, idCliente, idUsuario);
        }
        public void SalvarLog(string tela, string evento, int idCliente, int? idUsuario = null)
        {
            using (var context = new SysDbContext())
            {
                try
                {

                    LogModel log = new LogModel
                    {
                        Tela = tela,
                        Evento = evento,
                        IdUsuario = 1,
                    };

                    context.log.Add(log);

                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception("Ocorreu um erro ao salvar no banco de dados", ex);
                }

            }
        }
    }
}
