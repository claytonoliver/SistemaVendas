using Infraestrutura.DataBaseFactory;
using Infraestrutura.Entidades.Parametro;
using Microsoft.EntityFrameworkCore;
using Negocio.Parametros.Interfaces;
using System.ComponentModel;


namespace Negocio.Parametros
{

    public class ParametrosBiz : IParametrosBiz
    {
        public BindingList<ParametroModel> BuscarParametros()
        {
            var lista = new BindingList<ParametroModel>();

            using (var context = new SysDbContext())
            {
                var parametros = context.Parametros.ToList();

                foreach (var parametro in parametros)
                {
                    lista.Add(parametro);
                }
            }

            return lista;
        }

        public void IncluirNovoParametro(ParametroModel novoParametro)
        {
            using (var context = new SysDbContext())
            {
                try
                {
                    context.Parametros.Add(novoParametro);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception("Ocorreu um erro ao salvar no banco de dados", ex);
                }
            }
        }

        public void EditarParametro(ParametroModel parametro)
        {
            using (var context = new SysDbContext())
            {
                try
                {
                    var param = context.Parametros.SingleOrDefault(u => u.Id == parametro.Id);
                    if (param != null)
                    {
                        param.Chave = parametro.Chave;
                        param.Valor = parametro.Valor;
                        param.Descricao = parametro.Descricao;
                    }

                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception("Ocorreu um erro ao salvar no banco de dados", ex);
                }

            }
        }

        public void ExcluirParametro (int idUsuario)
        {
            using (var context = new SysDbContext())
            {
                try
                {
                    var param = context.Parametros.SingleOrDefault(u => u.Id == idUsuario);

                    context.Parametros.Remove(param);
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
