
//export default function App() { // 18
//    const [formData, setFormData] = useState({
//        id: '',
//        nip: '',
//        nazwa: '',
//        ulica: '',
//        miejscowosc: '',
//        kodPocztowy: '',
//        type: '',
//    })

class App extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            nip: '',
            nazwa: '',
            ulica: '',
            miejscowosc: '',
            kodPocztowy: '',
            regon: '',
            type: '',
            restext: '',
        };
    }

    handleChange = (e) => {
        if (e.target.name == 'nip')
            e.target.value = e.target.value.replace(/\D/g, "")

        this.setState({ [e.target.name]: e.target.value })
        //setFormData({ ...formData, [e.target.name]: e.target.value });
    }

    handleSubmit = (e) => {
        e.preventDefault();

        var data = { "d": JSON.stringify(this.state) }
        $.post("/Home/SaveData", data, function (r) {
            console.log(r.text)
        })
    }

    handleGetData = () => {
        var _this = this
        if (this.state.nip.length != 10) {
            _this.setState({ restext: "Niepoprawny format NIPu" })
            return
        }

        $.get("/Home/GetGUSdata?nip=" + this.state.nip, function (r) {
            if (r.result) {
                $.each(r.data, function (key, val) {
                    _this.setState({ [key]: val })
                })
            }
            if (r.text != '') {
                _this.setState({ restext: r.text })
            }
        })
    }

    render() {
        return (
            <div className="row">
                <h4 className="mb-3">Przedsiębiorca</h4>
                <div className="col-7">
                    <form onSubmit={this.handleSubmit} className="form-style">

                        <div className="row mb-2">
                            <label htmlFor="nip" className="col-3 col-form-label">NIP:</label>
                            <div className="col-7">
                                <input type="text" id="nip" name="nip" className="form-control"
                                    value={this.state.nip} onChange={this.handleChange} required />
                                <span asp-validation-for="nip" className="text-danger"></span>
                            </div>
                        </div>

                        <div className="row mb-2">
                            <div className="col-10 text-danger">{this.state.restext}</div>
                        </div>

                        <button type="button" className="btn btn-secondary btn-pobierz"
                            onClick={this.handleGetData}>Pobierz dane</button>
                        
                        <div className="row mb-2">
                            <label htmlFor="nazwa" className="col-3 col-form-label">Nazwa:</label>
                            <div className="col-7">
                                <input type="text" id="nazwa" name="nazwa" className="form-control"
                                    value={this.state.nazwa} onChange={this.handleChange} required />
                            </div>
                        </div>

                        <div className="row mb-2">
                            <label htmlFor="ulica" className="col-3 col-form-label">Ulica:</label>
                            <div className="col-7">
                                <input type="text" id="ulica" name="ulica" className="form-control"
                                    value={this.state.ulica} onChange={this.handleChange} required />
                            </div>
                        </div>

                        <div className="row mb-2">
                            <label htmlFor="kodPocztowy" className="col-3 col-form-label">Kod pocztowy:</label>
                            <div className="col-7">
                                <input type="text" id="kodPocztowy" name="kodPocztowy" className="form-control"
                                    value={this.state.kodPocztowy} onChange={this.handleChange} required />
                            </div>
                        </div>
                        
                        <div className="row mb-2">
                            <label htmlFor="miejscowosc" className="col-3 col-form-label">Miasto:</label>
                            <div className="col-7">
                                <input type="text" id="miejscowosc" name="city" className="form-control"
                                    value={this.state.miejscowosc} onChange={this.handleChange} required />
                            </div>
                        </div>

                        <div className="row mb-2">
                            <label htmlFor="regon" className="col-3 col-form-label">Regon:</label>
                            <div className="col-7">
                                <input type="text" id="regon" name="city" className="form-control"
                                    value={this.state.regon} onChange={this.handleChange} />
                            </div>
                        </div>

                        <button className="btn btn-primary" type="submit">Zapisz</button>
                    </form>
                </div>
            </div>
        );
    }
}

ReactDOM.render(<App />, document.getElementById('content'));