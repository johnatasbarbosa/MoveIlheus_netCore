
//Vue.component('opcao-component', {
//    props: ["opcao"],
//    template: `<option>{{opcao.texto}}</option>`,
//    watch: {
//        opcao: {
//            handler: function (newValue) {
//                console.log("Person with ID:" + newValue.id + " modified")
//                console.log("New age: " + newValue.texto)
//            },
//            deep: true
//        }
//    }
//});

var dimensaoPagina = {
    1: "400px",
    2: "500px",
    3: "600px"
}

var TipoConteudo  = {
    MultiplaEscolha: 1,
    CaixaSelecao: 2,
    ListaSuspensa: 3,
    Escala: 4,
    MultiplasRespostas: 5,
    DivisaoValores: 6,
    RespostaCurta: 7,
    RespostaLonga: 8,
    Descricao: 9,
    Cabecalho: 10,
    FerramentaDesenho: 11,
    Grafico: 12,
    RespostaNumerica: 13,
    CaixaConfirmacao: 14,
    RespostaPesquisa: 15
}

var TipoDesenho = {
    Marker: 1,
    Line: 2,
    Polygon: 3
}

function Desenho(desenho) {
    var self = this;
    self.id = desenho ? desenho.Id : 0;
    self.tipo = desenho ? desenho.Tipo : 0;

    self.coordenadas = [];
    self.respostasDesenho = [];

    self.respostaId = desenho ? desenho.RespostaId : 0;
}

function Coordenada(coordenada) {
    var self = this;
    self.id = coordenada ? coordenada.Id : 0;
    self.latitude = coordenada ? coordenada.Latitude : 0;
    self.longitude = coordenada ? coordenada.Longitude : 0;

    self.desenhoId = coordenada ? coordenada.DesenhoId : 0;
}

function ConteudoDesenho(conteudoDesenho) {
    console.log("conteudoDesenho", conteudoDesenho);
    var self = this;
    self.id = conteudoDesenho ? conteudoDesenho.Id : 0;
    self.tipo = conteudoDesenho ? conteudoDesenho.Tipo : 0;
    self.texto = conteudoDesenho ? conteudoDesenho.Texto : "";
    self.valor = conteudoDesenho ? conteudoDesenho.Valor : 0;
    self.sequencia = conteudoDesenho ? conteudoDesenho.Sequencia : 0;
    self.obrigatorio = conteudoDesenho ? conteudoDesenho.Obrigatorio : 0;

    self.opcoes = []
    self.resposta = [];

    if (conteudoDesenho) {
        if (conteudoDesenho.Opcoes)
            conteudoDesenho.Opcoes.forEach(function (opcao) {
                self.opcoes.push(new Opcao(opcao));
            })

        if (conteudoDesenho.Tipo == TipoConteudo.MultiplasRespostas) {
            for (var i = 0; i < conteudo.Valor; i++) {
                self.opcoes.push(new Opcao({ ConteudoDesenhoId: self.id }));
            }
        }
    }

    self.conteudoId = conteudoDesenho ? conteudoDesenho.ConteudoId : 0;

    self.adicionarOpcao = function () {
        self.opcoes.push(new Opcao({ ConteudoDesenhoId: self.id, Valor: 0 }));
    }
    self.removerOpcao = function (index) {
        self.opcoes.splice(index, 1);
    }

    self.salvar = function (conteudoId) {
        if (self.tipo == TipoConteudo.MultiplasRespostas) {
            self.opcoes = [];
        }

        self.conteudoId = conteudoId;
        App.$http.post(urlSalvarConteudoDesenho, { conteudo: this }).then(response => {
            var result = response.body;
            console.log(response.body);
            var conteudoId = response.body.Id;
            if (self.id == 0) {
                self.id = conteudoId;
            }
            conteudoId = self.id;
            self.opcoes.forEach(function (opcao, index) {
                opcao.conteudoId = conteudoId;
                opcao.id = response.body.Ids[index];
            })

            if (self.tipo == TipoConteudo.MultiplasRespostas) {
                for (var i = 0; i < self.valor; i++) {
                    self.opcoes.push(new Opcao({ ConteudoId: self.id }));
                }
            }

            App.conteudoDesenhoEditando = -1;
        }, response => {
            // error callback
        });
    }
}

function OpcaoResposta(opcaoResposta) {
    console.log("Adicionando opcaoResposta", opcaoResposta);
    var self = this;
    self.id = opcaoResposta ? opcaoResposta.Id :  0;
    self.valor = opcaoResposta ? opcaoResposta.Valor : 0;

    self.respostaId = opcaoResposta ? opcaoResposta.RespostaId : 0;;
    self.opcaoId = opcaoResposta ? opcaoResposta.OpcaoId : 0;;
}

function Resposta(resposta) {
    console.log("Adicionando resposta", resposta);
    var self = this;
    self.id = resposta ? resposta.Id : 0;
    self.texto = resposta ? resposta.Texto : "";
    self.valor = resposta ? resposta.Valor : 0;
    self.marcado = resposta ? resposta.Marcado : false;

    self.opcoes = [];
    self.desenhos = [];
    if (resposta && resposta.Opcoes) {
        resposta.Opcoes.forEach(function (opcao) {
            self.opcoes.push(new Opcao(opcao));
        })
    }

    self.conteudoId = resposta ? resposta.ConteudoId : 0;
}

function RestricaoConteudoPagina(restricaoConteudoPagina) {
    console.log("Adicionando restricaoConteudoPagina", restricaoConteudoPagina);
    var self = this;
    self.id = restricaoConteudoPagina ? restricaoConteudoPagina.Id : 0;
    self.nome = restricaoConteudoPagina ? restricaoConteudoPagina.Nome : "";

    self.restricaoPaginaId = restricaoConteudoPagina ? restricaoConteudoPagina.RestricaoPaginaId : 0;
    //self.paginaId = restricaoConteudoPagina ? restricaoConteudoPagina.PaginaId : 0;
    self.conteudoId = restricaoConteudoPagina ? restricaoConteudoPagina.ConteudoId : 0;
    self.conteudoIndex = 0;
    self.opcaoId = restricaoConteudoPagina ? restricaoConteudoPagina.OpcaoId : 0;

    self.adicionarConteudoIndex = function(conteudos) {
        conteudos.forEach(function (e, i, a) {
            if (e.id == self.conteudoId) {
                self.conteudoIndex = i;
            }
        })
    }
}

function RestricaoConteudo(restricaoConteudo) {
    console.log("Adicionando restricaoConteudo", restricaoConteudo);
    var self = this;
    self.id = restricaoConteudo ? restricaoConteudo.Id : 0;
    self.nome = restricaoConteudo ? restricaoConteudo.Nome : "";

    self.conteudoId = restricaoConteudo ? restricaoConteudo.ConteudoId : 0;
    self.paginaAlvoId = restricaoConteudo ? restricaoConteudo.PaginaAlvoId : 0;
    self.paginaIndex = -1;
    self.conteudoAlvoId = restricaoConteudo ? restricaoConteudo.ConteudoAlvoId : 0;
    self.conteudoIndex = -1;
    self.opcaoAlvoId = restricaoConteudo ? restricaoConteudo.OpcaoAlvoId : 0;
    
    self.adicionarPaginaIndex = function (paginas) {
        console.log("paginaAlvoId", self.paginaAlvoId);
        paginas.forEach(function (e, i, a) {
            if (e.id == self.paginaAlvoId) {
                self.paginaIndex = i;
            }
        })
        console.log("paginaIndex", self.paginaIndex);
    }
    self.adicionarConteudoIndex = function (conteudos) {
        console.log("conteudoAlvoId", self.conteudoAlvoId);
        if (self.conteudoAlvoId != 0) {
            conteudos.forEach(function (e, i, a) {
                if (e.id == self.conteudoAlvoId) {
                    self.conteudoIndex = i;
                }
            })
            console.log("conteudoIndex", self.conteudoIndex);
        }
    }


    self.ver = function () {
        var json = JSON.stringify(App.formulario.paginas[self.paginaIndex].conteudos[self.conteudoIndex]);
        console.log("rest", json);
    }
}

function RestricaoPagina(restricaoPagina) {
    console.log("Adicionando restricaoPagina", restricaoPagina);
    var self = this;
    self.id = restricaoPagina ? restricaoPagina.Id : 0;
    self.nome = restricaoPagina ? restricaoPagina.Nome : "";

    self.restricoesConteudosPagina = [];
    if (restricaoPagina && restricaoPagina.RestricoesConteudosPagina) {
        restricaoPagina.RestricoesConteudosPagina.forEach(function (restricaoConteudoPagina) {
            self.restricoesConteudosPagina.push(new RestricaoConteudoPagina(restricaoConteudoPagina));
        })
    }

    self.paginaId = restricaoPagina ? restricaoPagina.PaginaId : 0;
    self.proximaPaginaId = restricaoPagina ? restricaoPagina.ProximaPaginaId : 0;

    self.adicionarConteudo = function(){
        console.log("asd");
        self.restricoesConteudosPagina.push(new RestricaoConteudoPagina());
    }
    self.removerConteudo = function(index){
        self.restricoesConteudosPagina.splice(index, 1);
    }
}

function Formulario(formulario) {
    console.log("Adicionando formulario", formulario);
    var self = this;
    self.id = formulario ? formulario.Id : 0;
    self.nome = formulario ? formulario.Nome : "";
    
    self.paginas = [];
    if (formulario && formulario.Paginas) {
        formulario.Paginas.forEach(function (pagina) {
            self.paginas.push(new Pagina(pagina));
        })
    }
    
    self.novaPagina = function () {
        var novaPagina = new Pagina();
        novaPagina.formularioId = self.id;
        App.$http.post(urlSalvarPagina, { pagina: novaPagina }).then(response => {
            var result = response.body;
            console.log(response.body);
            var paginaId = response.body.Id;
            
            novaPagina.id = paginaId;
            self.paginas.push(novaPagina);
            App.paginaAtual = self.paginas.length - 1;
        }, response => {
            // error callback
        });
    }
    self.excluirPagina = function () {
        App.$http.post(urlExcluirPagina, { pagina: self.paginas[App.paginaAtual] }).then(response => {
            var result = response.body;
            console.log(response.body);

            var index = App.paginaAtual;
            if (App.paginaAtual > 0)
                App.paginaAtual = App.paginaAtual - 1;
            self.paginas.splice(index, 1);
        }, response => {
            // error callback
        });
    }
    self.duplicarPagina = function () {
        //var novaPagina = JSON.parse(JSON.stringify(self.paginas[App.paginaAtual]));
        var novaPagina = jQuery.extend(true, {}, self.paginas[App.paginaAtual])
        novaPagina.id = 0;
        novaPagina.restricoes.forEach(function (restricao) {
            restricao.id = 0;
            restricao.paginaId = 0;
            restricao.restricoesConteudosPagina.forEach(function (rcp) {
                rcp.id = 0;
                rcp.restricaoPaginaId = 0;
            })
        })
        novaPagina.conteudos.forEach(function (conteudo) {
            conteudo.id = 0;
            conteudo.paginaId = 0;
            conteudo.opcoes.forEach(function (opcao) {
                opcao.id = 0;
                opcao.conteudoId = 0;
            })
            conteudo.conteudosDesenhos.forEach(function (cd) {
                cd.id = 0;
                cd.conteudoId = 0;
            })
        })
        console.log(novaPagina);
        App.$http.post(urlSalvarNovaPagina, { pagina: novaPagina }).then(response => {
            var result = response.body;
            console.log(response.body);
            //var paginaId = response.body.Id;

            //novaPagina.id = paginaId;
            //self.paginas.push(novaPagina);
            App.obterFormulario();
            App.paginaAtual = self.paginas.length - 1;
        }, response => {
            // error callback
        });
    }
}

function Pagina(pagina) {
    console.log("Adicionando pagina", pagina);
    var self = this;
    self.id = pagina ? pagina.Id : 0;
    self.titulo = pagina ? pagina.Titulo : "Meu Título";
    self.dimensao = pagina ? pagina.Dimensao : 0;
    self.final = pagina ? pagina.Final : false;
    self.sequencia = pagina ? pagina.Sequencia : 0;
    
    self.conteudos = [];
    self.restricoes = [];
    if (pagina) {
        if (pagina.Conteudos) {
            pagina.Conteudos.sort(function (a, b) {
                if (a.Sequencia > b.Sequencia) {
                    return 1;
                }
                if (a.Sequencia < b.Sequencia) {
                    return -1;
                }
                // a must be equal to b
                return 0;
            });
            pagina.Conteudos.forEach(function (conteudo) {
                self.conteudos.push(new Conteudo(conteudo));
            })
        }
        if (pagina.Restricoes)
            pagina.Restricoes.forEach(function (restricao) {
                self.restricoes.push(new RestricaoPagina(restricao));
            })
    }

    self.formularioId = pagina ? pagina.FormularioId : 0;
    self.proximaPaginaId = pagina ? pagina.ProximaPaginaId : null;

    self.latitude = pagina ? pagina.Latitude : 0;
    self.longitude = pagina ? pagina.Longitude : 0;
    self.zoomLevel = pagina ? pagina.ZoomLevel : 0;
    self.definirLocalizacao = function () {
        var coord = map.getCenter();
        self.latitude = coord.lat();
        self.longitude = coord.lng();
        self.zoomLevel = map.getZoom();

        App.mostrarFormulario();
    }
    
    self.excluirConteudo = function (conteudo, index) {
        if (conteudo.id != 0) {
            App.$http.post(urlExcluirConteudo, { conteudo: conteudo }).then(response => {
                var result = response.body;
                console.log(response.body);

                App.conteudoEditando = -1;
                self.conteudos.splice(index, 1);
                App.obterFormulario();
            }, response => {
                // error callback
            });
        }
        else {
            App.conteudoEditando = -1;
            self.conteudos.splice(index, 1);
        }
    }

    self.adicionarRestricao = function(){
        var restricao = new RestricaoPagina();
        restricao.paginaId = self.id;
        restricao.adicionarConteudo();
        self.restricoes.push(restricao);
    }
    self.removerRestricao = function (index) {
        self.restricoes.splice(index, 1);
    }
    self.salvarConfiguracaoPagina = function () {
        App.$http.post(urlSalvarConfiguracaoPagina, { pagina: self }).then(response => {
            var result = response.body;
            console.log(response.body);

            if (response.body.Ids) {
                self.restricoes.forEach(function (restricao, index) {
                    restricao.paginaId = self.id;
                    restricao.id = response.body.Ids[index];
                })
            }

            if ($('#configuracoesPagina').hasClass('show'))
                $("#configuracoesPagina").modal('hide');
        }, response => {
            // error callback
        });
    }


    self.salvarPagina = function () {
        App.$http.post(urlSalvarPagina, { pagina: this }).then(response => {
            var result = response.body;
            console.log(response.body);

            //var paginaId = response.body.Id;            
        }, response => {
            // error callback
        });
    }
    self.atualizarSequenciaConteudos = function () {
        console.log("atualizando");
        self.conteudos.forEach(function (conteudo, index) {
            conteudo.sequencia = index;
        })
        
        App.$http.post(urlAtualizarSequenciaConteudos, { conteudos: self.conteudos }).then(response => {
            var result = response.body;
            console.log(response.body);
        }, response => {
            // error callback
        });
    }
}

function Conteudo(conteudo) {
    console.log("Adicionando conteudo", conteudo);
    var self = this;
    self.id = conteudo ? conteudo.Id : 0;
    self.tipo = conteudo ? conteudo.Tipo : 0;
    self.texto = conteudo ? conteudo.Texto : "";
    self.valor = conteudo ? conteudo.Valor : 0;
    self.sequencia = conteudo ? conteudo.Sequencia : 0;
    self.obrigatorio = conteudo ? conteudo.Obrigatorio : 0;
    self.tituloConteudosDesenho = conteudo ? conteudo.TituloConteudosDesenho : "";
    self.mensagemNovoDesenho = conteudo ? conteudo.MensagemNovoDesenho : "";

    self.opcoes = [];
    self.restricoes = [];
    self.respostas = [];
    self.conteudosDesenhos = [];
    if (conteudo) {
        if (conteudo.Opcoes)
            conteudo.Opcoes.forEach(function (opcao) {
                self.opcoes.push(new Opcao(opcao));
            })
        if (conteudo.Restricoes.length)
            conteudo.Restricoes.forEach(function (restricao) {
                self.restricoes.push(new RestricaoConteudo(restricao));
            })

        conteudo.ConteudosDesenhos.sort(function (a, b) {
            if (a.Sequencia > b.Sequencia) {
                return 1;
            }
            if (a.Sequencia < b.Sequencia) {
                return -1;
            }
            // a must be equal to b
            return 0;
        });
        if (conteudo.ConteudosDesenhos.length)
            conteudo.ConteudosDesenhos.forEach(function (conteudoDesenho) {
                self.conteudosDesenhos.push(new ConteudoDesenho(conteudoDesenho));
            })
        //if (conteudo.Respostas)
        //    conteudo.Respostas.forEach(function (resposta) {
        //        self.respostas.push(new Resposta(resposta));
        //    })

        if (conteudo.Tipo == TipoConteudo.MultiplasRespostas) {
            for (var i = 0; i < conteudo.Valor; i++) {
                self.opcoes.push(new Opcao({ ConteudoId: self.id }));
            }
        }
    }

    self.paginaId = conteudo ? conteudo.PaginaId : 0;

    self.adicionarOpcao = function () {
        self.opcoes.push(new Opcao({ ConteudoId: self.id, Valor: 0 }));
    }
    self.removerOpcao = function(index){
        self.opcoes.splice(index, 1);
    }
    
    self.adicionarRestricao = function () {
        var restricao = new RestricaoConteudo();
        restricao.conteudoId = self.id;
        self.restricoes.push(restricao);
    }
    self.excluirRestricao = function (index) {
        self.restricoes.splice(index, 1);
    }

    self.ver = function () {
        console.log(self.restricoes.length);
        if(self.restricoes.length > 0){
            var json = JSON.stringify(self.restricoes);
            console.log("rest", json);
        }
    }

    self.salvar = function (paginaId) {
        if (self.tipo == TipoConteudo.MultiplasRespostas) {
            self.opcoes = [];
        }

        self.paginaId = paginaId;
        App.$http.post(urlSalvarConteudo, { conteudo: this }).then(response => {
            var result = response.body;
            console.log(response.body);
            var conteudoId = response.body.Id;
            if (self.id == 0) {
                self.id = conteudoId;
            }
            conteudoId = self.id;
            self.opcoes.forEach(function (opcao, index) {
                opcao.conteudoId = conteudoId;
                opcao.id = response.body.Ids[index];
            })
            self.restricoes.forEach(function (restricao, index) {
                restricao.conteudoId = conteudoId;
                restricao.id = response.body.Ids2[index];
            })

            if (self.tipo == TipoConteudo.MultiplasRespostas) {
                for (var i = 0; i < self.valor; i++) {
                    self.opcoes.push(new Opcao({ ConteudoId: self.id }));
                }
            }

            App.editarConteudo(-1);
        }, response => {
            // error callback
        });
    }



    self.excluirConteudoDesenho = function (conteudo, index) {
        if (conteudo.id != 0) {
            App.$http.post(urlExcluirConteudoDesenho, { conteudo: conteudo }).then(response => {
                var result = response.body;
                console.log(response.body);

                App.conteudoDesenhoEditando = -1;
                self.conteudosDesenhos.splice(index, 1);
                //App.obterFormulario();
            }, response => {
                // error callback
            });
        }
        else {
            App.conteudoDesenhoEditando = -1;
            self.conteudosDesenhos.splice(index, 1);
        }
    }

    self.atualizarSequenciaConteudosDesenho = function () {
        console.log("atualizando");
        self.conteudosDesenhos.forEach(function (conteudo, index) {
            conteudo.sequencia = index;
        })

        App.$http.post(urlAtualizarSequenciaConteudosDesenhos, { conteudos: self.conteudosDesenhos }).then(response => {
            var result = response.body;
            console.log(response.body);
        }, response => {
            // error callback
        });
    }
}

function Opcao(opcao) {
    console.log("Adicionando opcao", opcao);
    var self = this;
    self.id = opcao ? opcao.Id : 0;
    self.texto = opcao ? opcao.Texto : "";
    self.valor = opcao ? opcao.Valor : 0;

    self.opcoesResposta = [];
    if (opcao && opcao.OpcoesResposta) {
        opcao.OpcoesResposta.forEach(function (opcaoResposta) {
            self.opcoesResposta.push(new OpcaoResposta(opcaoResposta));
        })
    }

    self.conteudoId = opcao ? opcao.ConteudoId : null;
    self.conteudoDesenhoId = opcao ? opcao.ConteudoDesenhoId : null;
}

var data = {
    options: [
        { value: 1, text: 'Múltipla Escolha' },
        { value: 2, text: 'Caixa de Seleção' },
        { value: 3, text: 'Lista Suspensa' },
        { value: 4, text: 'Escala' },
        // { value: 5, text: 'Escala Linear/Rating' },
        { value: 5, text: 'Múltiplas Respostas' },
        { value: 6, text: 'Divisão de valores' },
        { value: 7, text: 'Resposta curta' },
        { value: 8, text: 'Resposta longa' },
        { value: 9, text: 'Descrição' },
        { value: 10, text: 'Cabeçalho' },
        { value: 11, text: 'Ferramenta de Desenho' },
        //{ value: 12, text: 'Gráfico' },
        { value: 13, text: 'Resposta Numérica' },
        { value: 14, text: 'Caixa de Confirmação' },
        { value: 15, text: 'Resposta com Pesquisa' }
    ],
    optionsDesenhos: [
        { value: 1, text: 'Múltipla Escolha' },
        { value: 2, text: 'Caixa de Seleção' },
        { value: 3, text: 'Lista Suspensa' },
        { value: 4, text: 'Escala' },
        { value: 5, text: 'Múltiplas Respostas' },
        // { value: 5, text: 'Escala Linear/Rating' },
        { value: 6, text: 'Divisão de valores' },
        { value: 7, text: 'Resposta curta' },
        { value: 8, text: 'Resposta longa' },
        { value: 9, text: 'Descrição' },
        { value: 10, text: 'Cabeçalho' },
        { value: 13, text: 'Resposta Numérica' }
    ],
    selecionado: 0,
    formulario: new Formulario(formularioModel),
    paginaAtual: 0,
    conteudoEditando: -1,
    conteudoDesenhoEditando: -1,
    editando: [],
    editandoTitulo: false,
    adicionandoConteudo: false
};
window.App = new Vue({ 
    el: '#cadastro', 
    data: data,
    methods: {
        editarConteudo: function(index){
            console.log("editarConteudo", index);
            this.conteudoEditando = index;
            this.adicionandoConteudo = false;
            //console.log("index", this.pagina.conteudos[index]);
        },
        mouseEnter: function(index){
            console.log(index);
            // this.editando[index] = !this.editando[index];
            Vue.set(this.editando, index, true)
            // vm.items.splice(indexOfItem, 1, newValue)
        },
        mouseLeave: function (index) {
            console.log(index);
            // this.editando[index] = !this.editando[index];
            Vue.set(this.editando, index, false)
            // vm.items.splice(indexOfItem, 1, newValue)
        },
        selecionarTipoConteudo: function(index){
            this.selecionado = index;
            var conteudo = new Conteudo();
            conteudo.tipo = index;
            conteudo.sequencia = this.formulario.paginas[this.paginaAtual].conteudos.length
            if (index == TipoConteudo.MultiplaEscolha) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao());
                conteudo.opcoes.push(new Opcao());
            }
            if (index == TipoConteudo.CaixaSelecao) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao());
                conteudo.opcoes.push(new Opcao());
            }
            else if (index == TipoConteudo.ListaSuspensa) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao());
                conteudo.opcoes.push(new Opcao());
            }
            else if (index == TipoConteudo.Escala) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.valor = 50;
                conteudo.opcoes.push(new Opcao({ Texto: "Menor" }));
                conteudo.opcoes.push(new Opcao({ Texto: "Maior" }));
            }
            else if (index == TipoConteudo.MultiplasRespostas) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.valor = 1;
            }
            else if (index == TipoConteudo.DivisaoValores) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao({ Texto: "", Valor: 0 }));
            }
            else if (index == TipoConteudo.RespostaCurta) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            else if (index == TipoConteudo.RespostaLonga) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            else if (index == TipoConteudo.Descricao) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            else if (index == TipoConteudo.Cabecalho) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            this.formulario.paginas[this.paginaAtual].conteudos.push(conteudo);
            this.conteudoEditando = this.formulario.paginas[this.paginaAtual].conteudos.length - 1;
        },
        selecionarTipoConteudoDesenho: function (index) {
            this.selecionado = index;
            var conteudo = new ConteudoDesenho();
            conteudo.tipo = index;
            conteudo.sequencia = this.formulario.paginas[this.paginaAtual].conteudos[this.conteudoEditando].conteudosDesenhos.length
            if (index == TipoConteudo.MultiplaEscolha) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao());
                conteudo.opcoes.push(new Opcao());
            }
            if (index == TipoConteudo.CaixaSelecao) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao());
                conteudo.opcoes.push(new Opcao());
            }
            else if (index == TipoConteudo.ListaSuspensa) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao());
                conteudo.opcoes.push(new Opcao());
            }
            else if (index == TipoConteudo.Escala) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.valor = 50;
                conteudo.opcoes.push(new Opcao({ Texto: "Menor" }));
                conteudo.opcoes.push(new Opcao({ Texto: "Maior" }));
            }
            else if (index == TipoConteudo.DivisaoValores) {
                //conteudo.pergunta = "Insira a pergunta";
                conteudo.opcoes.push(new Opcao({ Texto: "", Valor: 0 }));
            }
            else if (index == TipoConteudo.RespostaCurta) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            else if (index == TipoConteudo.RespostaLonga) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            else if (index == TipoConteudo.Descricao) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            else if (index == TipoConteudo.Cabecalho) {
                //conteudo.pergunta = "Insira a pergunta";
            }
            this.formulario.paginas[this.paginaAtual].conteudos[this.conteudoEditando].conteudosDesenhos.push(conteudo);
            this.conteudoDesenhoEditando = this.formulario.paginas[this.paginaAtual].conteudos[this.conteudoEditando].conteudosDesenhos.length - 1;
        },
        obterFormulario: function () {
            //this.$http.get(urlObterFormularioParaEditar, { params: { foo: 'bar' }, headers: { 'X-Custom': '...' } }).then(response => {
            this.$http.get(urlObterFormulariòParaEditar).then(response => {

                // get body data
                console.log("obterFormulario", response);
                this.formulario = new Formulario(JSON.parse(response.body.data));

            }, response => {
                console.log("Erro");
                // error callback
            });
        },
        salvarFormulario: function () {
            this.formulario.nome = "Meu formulário";
            var data = JSON.stringify({ Formulario: this.formulario });
            console.log(data);
            this.$http.post(urlSalvarFormulario, { formulario: this.formulario }).then(response => {
                // get status
                response.status;

                // get status text
                response.statusText;

                // get 'Expires' header
                response.headers.get('Expires');

                // get body data
                console.log(response.body);
                var result = response.body;
                var formularioId = response.body.Id;
                this.formulario.id = formularioId;
                //Não precisa mais
                //this.formulario.paginas.forEach(function (pagina) {
                //    pagina.formularioId = formularioId;
                //})

            }, response => {
                // error callback
            });
        },
        esconderFormulario: function () {
            //var elementos = document.getElementById("formulario")
            //elementos.hidden = true;
            $("#formulario").hide();
            $(".modal-backdrop").hide();
            $("#map").show();
            $("#defineLocalizacao").show();
            //var mapaElemento = document.getElementById("map")
            //mapaElemento.hidden = false;
            if (this.formulario.paginas[this.paginaAtual].zoomLevel != 0) {
                var latlng = new google.maps.LatLng(parseFloat(this.formulario.paginas[this.paginaAtual].latitude), parseFloat(this.formulario.paginas[this.paginaAtual].longitude));
                map.setCenter(latlng);
                //map.setCenter({ lat: this.formulario.paginas[this.paginaAtual].latitude, lng: this.formulario.paginas[this.paginaAtual].longitude });
                map.setZoom(parseInt(this.formulario.paginas[this.paginaAtual].zoomLevel));
            }
        },
        mostrarFormulario: function () {
            $("#formulario").show();
            $(".modal-backdrop").show();
            $("#map").hide();
            $("#defineLocalizacao").hide();
        }
    }
});
