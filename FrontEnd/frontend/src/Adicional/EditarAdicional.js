import React, { Component } from 'react'
import Layout from '../Layout/Layout';
import Conexao from '../Conexao/Conexao';

export default class EditarAdicional extends Component {
    constructor(props) {
        super(props)

        //console.log(props);
        //console.log(this.props.match.params.id);
        this.state = {
            id: this.props.match.params.id,
            nome: "",
            tipo: "",
            valor: "",
            ativo: true,
            erro: null
        }
        
        this.setNome = this.setNome.bind(this)
        this.setNome = this.setNome.bind(this)
        this.setTipo = this.setTipo.bind(this)
        this.setValor = this.setValor.bind(this)
        this.setAtivo = this.setAtivo.bind(this)
        this.enviarParaBackEnd = this.enviarParaBackEnd.bind(this);
    }

    componentDidMount() {
        Conexao.get("/Adicional/" + this.state.id).then(resposta => {
            const dados = resposta.data;
            if (dados.erro != null) {
                this.setState({ erro: dados.erro });
            } else {
                this.setState({

                    id: dados.id,
                    nome: dados.nome,
                    tipo: dados.tipo,
                    valor: dados.valor,
                    ativo: dados.ativo

                });
            }
        });
    }

    setNome(e) {
        this.setState({
            nome: e.target.value,
        })
    }

    setTipo(e) {
        this.setState({
            tipo: e.target.value,
        })
    }
    setValor(e) {
        this.setState({
            valor: e.target.value,
        })
    }
    setAtivo(e) {
        this.setState({
            ativo: e.target.value === 'true' ? true : false
        });
    }
    enviarParaBackEnd() {
        console.log(this.state)
        Conexao.post("/Adicional", {
            id: this.state.id,
            nome: this.state.nome,
            tipo: this.state.tipo,
            valor: this.state.valor,
            ativo: this.state.ativo

        }).then(resposta => {
            const dados = resposta.data;
            console.log(dados.erro)
            if (dados.erro != null) {
                this.setState({ erro: dados.erro });
            } else {
                //alert("deu");
                this.props.history.push('/ListaAdicional')
            }
        }).catch(error => {
            console.log(error)
        })


    }
    render() {
        return (
            <Layout>
                {this.state.erro != null ?
                    <div className="alert alert-danger alert-dismissible fade show" role="alert">
                        {this.state.erro}
                        <button type="button" onClick={() => this.setState({ erro: null })} className="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    </div>
                    : ""}

                <div className="col-4"></div>
                <div className="col-4">

                    <div className="form-group">
                        <label>Código</label>
                        <input type="text" readOnly={true} className="form-control" id="id" name="id" value={this.state.id} />
                    </div>
                    <div className="form-group"  >
                        <label>Nome</label>
                        <input type="text" className="form-control" id="nome" name="nome" value={this.state.nome} onChange={this.setNome} />
                    </div>
                    <div className="form-group" >
                        <label>Tipo</label>
                        <input type="text" className="form-control" id="tipo" name="tipo" value={this.state.tipo} onChange={this.setTipo} />
                    </div>
                    <div className="form-group" >
                        <label>Valor</label>
                        <input type="number" className="form-control" name="valor" value={this.state.valor} onChange={this.setValor} />
                    </div>

                    <div className="form-group ">
                        <label> Ativo: </label>
                        <select className="form-control" value={this.state.ativo} onChange={this.setAtivo}>
                            <option value="true">Sim</option>
                            <option value="false">Não</option>
                        </select>
                    </div>

                    </div>
                    <br></br>




                    <div className="row">
                        <button className="btn btn-success" onClick={this.enviarParaBackEnd}>Salvar</button>
                    </div>

            </Layout>);
    }
}

