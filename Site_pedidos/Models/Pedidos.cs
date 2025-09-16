

using System;
using System.ComponentModel.DataAnnotations;

#nullable enable
namespace Pedidos_view.Models;

public class Pedidos
{
    [Display(Name = "CODIGO ERP")]
    public string? pedido_ERP { get; set; }

    [Display(Name = "DATA DE EMISSÃO")]
    public DateOnly? data_emissao { get; set; }

    [Display(Name = "CODIGO")]
    public string? codigo { get; set; }

    [Display(Name = "CLIENTE")]
    public string? cliente { get; set; }

    [Display(Name = "PRODUTO")]
    public string? produto { get; set; }

    [Display(Name = "PREÇO PEDIDO")]
    public float? preço_pedido { get; set; }

    [Display(Name = "QUANTIDADE")]
    public float? quantidade { get; set; }

    [Display(Name = "STATUS")]
    public string? status { get; set; }

    [Display(Name = "ASSESSOR")]
    public string? assessor { get; set; }

    [Display(Name = "HORA")]
    public string? hora { get; set; }

    public int? minutos_decorridos { get; set; }
}
