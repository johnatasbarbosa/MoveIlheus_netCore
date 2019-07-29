using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    public enum TipoConteudo
    {
        MultiplaEscolha = 1,
        CaixaSelecao = 2,
        ListaSuspensa = 3,
        Escala = 4,
        //Rating = 5,
        MultiplasRespostas = 5,
        DivisaoValores = 6,
        RespostaCurta = 7,
        RespostaLonga = 8,
        Descricao = 9,
        Cabecalho = 10,
        DrawMarker = 11,
        DrawLine = 12,
        DrawPolygon = 13
    }
}