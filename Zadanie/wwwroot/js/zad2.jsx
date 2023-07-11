
class App extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            tasks: [],
            currentName: '',
            timer: 0,
            started: false,
            index: 0
        };
    }

    handleChange = (e) => {
        this.setState({ [e.target.name]: e.target.value })
    }

    handleStartTask = () => {
        this.interval = setInterval(() => {
            this.setState(prevState => ({
                timer: prevState.timer + 1
            }));
        }, 1000);
        this.setState({ started: true })
    }

    handleEndTask = () => {
        clearInterval(this.interval);
        var i = this.state.index + 1;
        this.state.tasks.push({
            index: i,
            name: this.state.currentName,
            time: this.state.timer
        })
        this.setState({ currentName: '', timer: 0, index: i, started: false })
    }

    render() {
        const tasks = [...this.state.tasks].reverse().map(item => (
            <TaskElem name={item.name} key={item.index} index={item.index} time={item.time} />
        ))

        return (
            <form>
                <div className="row">
                    <h4 className="mb-3">Lista zadań</h4>
                </div>
                <AddTask
                    handleChange={this.handleChange}
                    handleStartTask={this.handleStartTask}
                    handleEndTask={this.handleEndTask}
                    currentName={this.state.currentName}
                    timer={this.state.timer}
                    started={this.state.started}
                />
                <div className="m-3">
                    {tasks}
                </div>
            </form>
        );
    }
}

function TaskElem(props) {
    return (
        <div className="row">
            <div className="col-1">{props.index}</div>
            <div className="col-4">{props.name}</div>
            <div className="col-3">{props.time}</div>
        </div>
    )
}

class AddTask extends React.Component {
    render() {
        return (
            <div className="row">
                <div className="col-7">
                    <div className="mb-2 row">
                        <label htmlFor="currentName" className="col-form-label col-3">Nazwa zadania:</label>
                        <div className="col-5">
                            <input type="type" id="currentName" name="currentName" className="form-control"
                                value={this.props.currentName} onChange={this.props.handleChange} />
                        </div>
                        <div className="col-3">
                            <span className="badge bg-secondary">{this.props.timer}</span>
                        </div>
                    </div>
                    <div>
                        <button type="button" className="btn btn-success" onClick={this.props.handleStartTask} disabled={this.props.started}>Rozpocznij zadanie</button> &nbsp;
                        <button type="button" className="btn btn-danger" onClick={this.props.handleEndTask} disabled={!this.props.started}>Zakończ zadanie</button>
                    </div>
                </div>
            </div>
        )
    }
}

ReactDOM.render(<App />, document.getElementById('content'));