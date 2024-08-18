using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestrutura.Entidades.Parametro;

[Table("Parametros")]
public class ParametroModel
{
    public int Id { get; set; }
    public string Chave { get; set; }
    public string Valor { get; set; }
    public string Descricao { get; set; }
}
