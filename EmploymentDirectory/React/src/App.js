// import logo from './logo.svg';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import GetBussinesDetailsForClient from './EmploymentDirectory/HomePage';
// import GetBussinesDetailsForBussinesOwnerByPassword from './EmploymentDirectory/Login';
import AddBusinessDetails from './EmploymentDirectory/AddBussinesDetails';
import LoginPage from './EmploymentDirectory/Login';

import UpdateBusinessDetails from './EmploymentDirectory/UpdateBussinesDetails';
// import Search from './EmploymentDirectory/Search';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Employment Directory</h1>
        {/* <Search /> */}
        <BrowserRouter>
          <Routes>
            <Route exact path='/' element={<GetBussinesDetailsForClient/>} />
            <Route exact path='/Login' element={<LoginPage/>}/>
            <Route exact path='/AddBusinessDetails' element={<AddBusinessDetails/>} />
            <Route exact path='/UpdateBusinessDetails' element={<UpdateBusinessDetails/>}/>
          </Routes>
        </BrowserRouter>
        {/* <img src={logo} className='App-logo' alt='logo'/>
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a> */}
      </header>
    </div>
  );
}

export default App;