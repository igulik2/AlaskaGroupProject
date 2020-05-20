import React, { Component } from 'react'
import Layout from '../Layout/Layout';
import Conexao from '../Conexao/Conexao';
import { browserHistory } from 'react-router'
export default class CadastroCasquinha extends Component {
    constructor(props) {
        super(props)
        this.state = {

            nome: "",
            tipo: "",
            preco: "",
            ativo: true,
            erro: null
        }

        this.setNome = this.setNome.bind(this)
        this.setTipo = this.setTipo.bind(this)
        this.setPreco = this.setPreco.bind(this)
        this.setAtivo = this.setAtivo.bind(this)
        this.enviarParaBackEnd = this.enviarParaBackEnd.bind(this);
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

    setPreco(e) {
        this.setState({
            preco: e.target.value,
        })
    }
  
    setAtivo(e) {
        this.setState({
            ativo: e.target.value,
        })
    }
    enviarParaBackEnd() {
        console.log(this.state)
        Conexao.post("/Casquinha", { 
            nome: this.state.nome,
            tipo: this.state.tipo,
            preco: this.state.preco,
            ativo: this.state.ativo,

         }).then(resposta => {
            const dados = resposta.data;
            console.log(dados.erro)
            if (dados.erro != null) {
                this.setState({ erro: dados.erro });
            } else {
                alert("deu");
                this.props.history.push('/ListaCasquinha')
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

                <div className="row">

                    <div className="col-4"></div>
                    <div className="col-4">
                    
                        
                        <div className="form-group" >
                            <label>Nome</label>
                            <input type="text" className="form-control" id="nome" name="nome" value={this.state.nome} onChange={this.setNome} />
                        </div>
                       
                        
                        <div className="form-group" >
                            <label>Tipo</label>
                            <input type="text" className="form-control" id="tipo" name="tipo" value={this.state.tipo} onChange={this.setTipo} />
                        </div>
                        
                        <div className="form-group" >
                            <label>Preço</label>
                            <input type="text" className="form-control" name="preco" value={this.state.preco} onChange={this.setPreco} />
                       </div>

                       <div className="form-group ">
                        <label> Ativo: </label>
                            <select className="form-control" value={this.state.ativo} onChange={this.setAtivo}>
                             <option value="">Selecione...</option>
                             <option value="1">Sim</option>
                             <option value="2">Não</option>
                            </select>
                        </div>
                        </div>
                        
                        
                        
                    </div><br></br>
                   
                    <div class="row">
                        <button className="btn btn-success" onClick={this.enviarParaBackEnd}>Salvar</button>
                     </div>
                     
                    <div className="col-4"></div>

               
            </Layout>);
    }
}
