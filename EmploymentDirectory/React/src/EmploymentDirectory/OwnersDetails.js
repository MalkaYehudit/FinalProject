import React from "react"
import { useState, useEffect } from "react"
import { useNavigate } from "react-router-dom";

function GetOwnersDetails() {
    const [ownersDetails, setOwnersDetails] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        fetch('http://localhost:5111/api/BussinesDetailsForBussinesOwners')
            .then(response => response.json())
            .then((data) => {
                setOwnersDetails(data);
                console.log(data);
            })
            .catch(error => console.error(error));
    }, []);
    return (
        <>
            {<div class="ownersDetails">
                {ownersDetails.map(item => (
                    <div class="ownersDetailsCard">
                        <div class="card-body">
                            <h3 class="card-title">{item.bussinesName} <button id={item.id} onClick={() => navigate('/DeleteDetail')}><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
  <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5m3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0z"/>
  <path d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4zM2.5 3h11V2h-11z"/>
</svg></button></h3>
                            <p class="card-text">{item.firstName} {item.lastName}</p>
                            <p class="card-text">{item.addressId}</p>
                            <p class="card-text">{item.priceRange}</p>
                            <p class="card-text">{item.experience}</p>
                        </div>
                    </div>
                ))}
            </div>}
        </>
    )
}
export default GetOwnersDetails;