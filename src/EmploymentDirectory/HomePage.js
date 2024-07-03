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
        setBussinesDetailsForClients(res.data)
        console.log(bussinesDetailsForClients);
      })
      .catch(error => console.error(error));
  },);

 

  return (
    <>
      {<div class="bussinesDetails">
        {bussinesDetailsForClients.map(item => (
          <div class="bussinesDetailsCard">
            <div class="card-body">
              <h3 class="card-title">{item.bussinesName}</h3>
              <p class="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
              <p class="card-text">{item.addressId}</p>
              <p class="card-text">{item.priceRange}</p>
              <p class="card-text">{item.experience}</p>
            </div>
          </div>
        ))}
      </div>}

        
      <button type="button" class="btn btn-outline-info" onClick={() => navigate('/OwnersDetails')}>Login</button>
    </>
  )
}
export default GetBussinesDetailsForClient;