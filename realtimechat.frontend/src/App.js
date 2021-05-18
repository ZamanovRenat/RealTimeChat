import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Lobby from './components/Lobby';

const App = () => {
  const joinRoom = async (user, room) => {
    try {

    } catch (e) 
    {
      console.log(e);
    }
  }
  return <div className='app'>
    <h2>Real Time Chat</h2>
    <hr className='line' />
    <Lobby joinRoom={joinRoom} />
  </div>
}

export default App;
