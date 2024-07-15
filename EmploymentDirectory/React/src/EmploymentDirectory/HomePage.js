import axios from "axios";
import React from "react";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

function GetBussinesDetailsForClient() {
  const navigate = useNavigate();
  const [bussinesDetailsForClients, setBussinesDetailsForClients] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5111/api/BussinesDetailsForClients')
      .then(res => {
        setBussinesDetailsForClients(res.data);
      })
      .catch(error => {
        console.error('Error fetching business details:', error);
      });
  }, []);

  useEffect(() => {
    console.log('Business details:', bussinesDetailsForClients);
  }, [bussinesDetailsForClients]);

  return (
    <>

      <div className="row justify-content-center">
        {bussinesDetailsForClients.map((item, index) => (
          <div key={index} className="col-lg-4 col-md-6 mb-4 d-flex justify-content-center">
            <div className="card" style={{ width: "20rem" }}>
              <div className="card-body">
                <h5 className="card-title">{item.bussinesName}</h5>
                <p className="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
                <p className="card-text">{item.addressId}</p>
                <p className="card-text">Price range: {item.priceRange}</p>
                <p className="card-text">Experience: {item.experience}</p>
                <a href="#" className="btn btn-primary">For Information</a>
              </div>
            </div>
          </div>
        ))}
      </div>


      <button type="button" className="btn btn-outline-info" onClick={() => navigate('/Login')}>Login</button>
      <button type="button" className="btn btn-outline-info" onClick={() => navigate('/AddBusinessDetails')}>Sign Up</button>
    </>
  );
}



export default GetBussinesDetailsForClient;