using Infraestrutura.Entidades.Parametro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Parametros.Interfaces
{
    public interface IParametrosBiz
    {
        BindingList<ParametroModel> BuscarParametros();
        void IncluirNovoParametro(ParametroModel novoParametro);
        void EditarParametro(ParametroModel novoParametro);
        void ExcluirParametro(int idUsuario);
    }
}
