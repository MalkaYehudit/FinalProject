import React from'react';
import axios from "axios";

function GetBussinesDetailsForBussinesOwner() {
  axios.get('http://localhost:5111/api/BussinesDetailsForBussinesOwners')
   .then(res => {
    const bussinesDetailsForBussinesOwner = res.data;
    console.log(bussinesDetailsForBussinesOwner);
  })
  .catch(error => {
    console.error(error);
  });

  return (
    <>
      
    </>
  );
}

export default GetBussinesDetailsForBussinesOwner;

  