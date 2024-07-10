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

      {/* <div className="businessDetails">
        {bussinesDetailsForClients.length > 0 ? (
          bussinesDetailsForClients.map(item => (
            <div class="card" style={{width: 18+'rem'}}>
              <div class="card-body">
                <h5 class="card-title">{item.bussinesName}</h5>
                <p className="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
                <p className="card-text">{item.addressId}</p>
                <p className="card-text">price range: {item.priceRange}</p>
                <p className="card-text">experience: {item.experience}</p>
                <a href="#" class="btn btn-primary">For Information</a>
              </div>
            </div>
            // <div className="businessDetailsCard" key={item.id}>
            //   <div className="card-body">
            //     <h3 className="card-title">{item.bussinesName}</h3>
            //     <p className="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
            //     <p className="card-text">{item.addressId}</p>
            //     <p className="card-text">{item.priceRange}</p>
            //     <p className="card-text">{item.experience}</p>
            //   </div>
            // </div>
        ))
        ) : (
        <p>No business details available</p>
        )}
      </div> */}

      <button type="button" className="btn btn-outline-info" onClick={() => navigate('/OwnersDetails')}>Login</button>
    </>
  );
}



export default GetBussinesDetailsForClient;