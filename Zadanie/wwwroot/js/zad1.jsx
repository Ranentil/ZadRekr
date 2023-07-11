import React from 'react';

export default function App() {
    const [formData, setFormData] = useState({
        id: '',
        nip: '',
        nazwa: '',
        ulica: '',
        miejscowosc: '',
        kodpocztowy: '',
        type: '',
    })

    const handleChange = (event) => {
        setFormData({ ...formData, [event.target.name]: event.target.value });
    }

    const handleSubmit = (event) => {
        event.preventDefault();
        // Perform form submission logic or API call here using formData
        console.log(formData);
    }

    handleGetData = (event) => {
        $.get("/Home/GetGUSdata", function (r) {
            if (r.result)
                console.log(r.data)
            else
                console.log("Wystąpił błąd")
        })
    }

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <label htmlFor="nip">NIP:</label>
                <input type="text" id="nip" name="nip" value={formData.nip} onChange={handleChange} />

                <button type="button">Pobierz dane</button>

                <label htmlFor="nazwa">Nazwa:</label>
                <input type="text" id="nazwa" name="nazwa" value={formData.nazwa} onChange={handleChange} />

                <label htmlFor="ulica">Ulica:</label>
                <input type="text" id="ulica" name="ulica" value={formData.ulica} onChange={handleChange} />

                <label htmlFor="kodpocztowy">Kod pocztowy:</label>
                <input type="text" id="kodpocztowy" name="kodpocztowy" value={formData.kodpocztowy} onChange={handleChange} />

                <label htmlFor="Miejscowosc">Miasto:</label>
                <input type="text" id="Miejscowosc" name="city" value={formData.miejscowosc} onChange={handleChange} />

                <button type="submit">Zapisz</button>
            </form>
        </div>
    )

    //return (
    //    <Content
    //        handleSubmit={handleSubmit}
    //        handleChange={handleChange}
    //    />
    //)
}

//function Content(props) {
//    return (
//    );
//}


const root = ReactDOM.createRoot(document.getElementById("content"));
root.render(<App />);

//const app = document.getElementById('content');
//const root = createRoot(app);