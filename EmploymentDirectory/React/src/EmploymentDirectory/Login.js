// import React, { useState } from 'react';
// import axios from 'axios';
// import { useNavigate } from "react-router-dom";



// const LoginPage = () => {
//     const [password, setPassword] = useState('');
//     const [userDetails, setUserDetails] = useState(null);
//     // const [loggedIn, setLoggedIn] = useState(true);
//     const [error, setError] = useState('');
//     const navigate = useNavigate();


//     const handleSubmit = async (e) => {
//         e.preventDefault();

//         try {
//             const response = await axios.get(`http://localhost:5111/api/BussinesDetailsForBussinesOwners/GetBussinesDetailsForBussinesOwnerByPassword?password=${encodeURIComponent(password)}`);

//             if (response.status === 200) {
//                 setUserDetails(response.data); // Assuming data returned is user details
//                 // setLoggedIn(true);
//                 setError('');
//                 navigate('/UpdateBusinessDetails'); // Redirect to dashboard page after successful login
//             } else {
//                 throw new Error('Login failed');
//             }
//         } catch (error) {
//             setError('Login failed. Please check your credentials.');
//             setUserDetails(null);
//         }
//     };


//     return (
//         <div>
//             <form onSubmit={handleSubmit}>
//                 <input
//                     // type="password"
//                     placeholder="Password"
//                     value={password}
//                     onChange={(e) => setPassword(e.target.value)}
//                 />
//                 <button type="submit">Login</button>
//             </form>
//             {error && <p>{error}</p>}
//             {/* {userDetails && (
//                 <div>
//                     <h2>User Details</h2>
//                     <p>Username: {userDetails.bussinesName}</p>
//                     <p>Email: {userDetails.firstNameOfOwner}{userDetails.lastNameOfOwner}</p>
//                 </div>
//                             <div className="card" style={{ width: "20rem" }}>
//                             <div className="card-body">
//                               <h5 className="card-title">{item.bussinesName}</h5>
//                               <p className="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
//                               <p className="card-text">{item.addressId}</p>
//                               <p className="card-text">Price range: {item.priceRange}</p>
//                               <p className="card-text">Experience: {item.experience}</p>
//                               <a href="#" className="btn btn-primary">For Information</a>
//                             </div>
//             )} */}
//         </div>
//     );
// };

// export default LoginPage;


import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from "react-router-dom";

const LoginPage = () => {
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();

        try {
            const response = await axios.get(`http://localhost:5111/api/BussinesDetailsForBussinesOwners/GetBussinesDetailsForBussinesOwnerByPassword?password=${encodeURIComponent(password)}`);

            if (response.status === 200) {
                // Redirect to profile page and pass user details via state
                navigate('/UpdateBusinessDetails', { state: { userDetails: response.data } });
            } else {
                throw new Error('Login failed');
            }
        } catch (error) {
            setError('Login failed. Please check your credentials.');
        }
    };

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <input
                    type="password"
                    placeholder="Password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                />
                <button type="submit">Login</button>
            </form>
            {error && <p>{error}</p>}
        </div>
    );
};

export default LoginPage;






// import React, { useState } from 'react';
// import axios from 'axios';

// function LoginPage() {
//     const [password, setPassword] = useState('');
//     const [bussinesDetailsForBussinesOwnerByPassword, setBussinesDetailsForBussinesOwnerByPassword] = useState({});//check
//     const [loading, setLoading] = useState(false);
//     const [error, setError] = useState('');

//     const handleSubmit = async (event) => {
//         event.preventDefault();
//         setLoading(true);
//         try{
//             const response = await axios.get(`http://localhost:5111/api/BussinesDetailsForBussinesOwners/GetBussinesDetailsForBussinesOwnerByPassword?password=${encodeURIComponent(password)}`);
//             setBussinesDetailsForBussinesOwnerByPassword(response.data);
//             window.location.href = '/dashboard';

//         }catch (error) {
//             console.error('Error adding business details:', error);
//             setError('Failed to add business details');
//             setLoading(false);
//         }
//         // const url = `http://localhost:5111/api/BussinesDetailsForBussinesOwners/GetBussinesDetailsForBussinesOwnerByPassword?password=${encodeURIComponent(password)}`;
//         // window.location.href = url;
//     };

//     return (
//         <div>
//             <h2>Login Page</h2>
//             <form onSubmit={handleSubmit}>
//                 <input
//                     placeholder="Enter password"
//                     type="password"
//                     value={password}
//                     onChange={(e) => setPassword(e.target.value)}
//                     required
//                 />
//                 <button type="submit">Login</button>
//             </form>
//         </div>
//     );
// }

// export default LoginPage;

// // import React from "react";
// // import axios from "axios";
// // import { useState, useEffect } from "react";

// // function GetBussinesDetailsForBussinesOwnerByPassword() {
// //     const [password, setPassword] = useState('');
// //     const [bussinesDetailsForBussinesOwnerByPassword, setBussinesDetailsForBussinesOwnerByPassword] = useState([]);

// //     useEffect(() => {
// //         axios.get('http://localhost:5111/api/GetBussinesDetailsForBussinesOwnerByPassword', {
// //             params: {
// //                 password: password
// //             }
// //         })
// //             .then(response => {
// //                 setBussinesDetailsForBussinesOwnerByPassword(response.data);
// //             })
// //             .catch(error => {
// //                 console.error('Error fetching business details:', error);
// //                 // setBussinesDetailsForBussinesOwnerByPassword(null);
// //             });
// //     },[]);

// //     useEffect(() => {
// //         console.log('Bussines details:', bussinesDetailsForBussinesOwnerByPassword);
// //     },[bussinesDetailsForBussinesOwnerByPassword]);

// //     const handleSubmit = (event) => {
// //         event.preventDefault();
// //         console.log("Submit");
// //     };

// //     return (
// //         <>
// //             <form onSubmit={handleSubmit}>
// //                 <input placeholder="password" type="password" value={password} onChange={(e) => setPassword(e.target.value)} required />
// //                 <button type="submit">Fetch Details</button>
// //             </form>

// //             <div className="card" style={{ width: "20rem" }}>
// //               <div className="card-body">
// //                 <h5 className="card-title">{bussinesDetailsForBussinesOwnerByPassword.bussinesName}</h5>
// //                 <p className="card-text">{bussinesDetailsForBussinesOwnerByPassword.firstNameOfOwner} {bussinesDetailsForBussinesOwnerByPassword.lastNameOfOwner}</p>
// //                 <p className="card-text">{bussinesDetailsForBussinesOwnerByPassword.addressId}</p>
// //                 <p className="card-text">Price range: {bussinesDetailsForBussinesOwnerByPassword.priceRange}</p>
// //                 <p className="card-text">Experience: {bussinesDetailsForBussinesOwnerByPassword.experience}</p>
// //                 <a href="#" className="btn btn-primary">For Information</a>
// //           </div>
// //         </div>

// //             {/* <div className="row justify-content-center">
// //                 {bussinesDetailsForBussinesOwnerByPassword.map((item, index) => (
// //                     <div key={index} className="col-lg-4 col-md-6 mb-4 d-flex justify-content-center">
// //                         <div className="card" style={{ width: "20rem" }}>
// //                             <div className="card-body">
// //                                 <h5 className="card-title">{item.bussinesName}</h5>
// //                                 <p className="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
// //                                 <p className="card-text">{item.addressId}</p>
// //                                 <p className="card-text">Price range: {item.priceRange}</p>
// //                                 <p className="card-text">Experience: {item.experience}</p>
// //                                 <a href="#" className="btn btn-primary">For Information</a>
// //                             </div>
// //                         </div>
// //                     </div>
// //                 ))}
// //             </div> */}
// //         </>
// //     );
// // }


// // export default GetBussinesDetailsForBussinesOwnerByPassword;


// import React, { useState, useEffect } from "react";
// import axios from "axios";

// function GetBussinesDetailsForBussinesOwnerByPassword() {
//     const [password, setPassword] = useState('');
//     const [bussinesDetailsForBussinesOwnerByPassword, setBussinesDetailsForBussinesOwnerByPassword] = useState(null);
//     const [loading, setLoading] = useState(false);
//     const [error, setError] = useState('');

//     const handleSubmit = async (event) => {
//         console.log("submit");
//         event.preventDefault();
//         setLoading(true);
        
//         try {
//             const response = await axios.get('http://localhost:5111/api/GetBussinesDetailsForBussinesOwnerByPassword', {
//                 params: {
//                     password: password
//                 }
//             });
//             console.log('Response:', response.data);
//             setBussinesDetailsForBussinesOwnerByPassword(response.data);
//             setLoading(false);
//             setError('');
//         } catch (error) {
//             console.error('Error fetching business details:', error);
//             setError('Failed to fetch business details');
//             setLoading(false);
//             setBussinesDetailsForBussinesOwnerByPassword(null);
//         }
//     };

//     useEffect(() => {
//         console.log('Business details:', bussinesDetailsForBussinesOwnerByPassword);
//     }, [bussinesDetailsForBussinesOwnerByPassword]);

//     return (
//         <>
//             <form onSubmit={handleSubmit}>
//                 <input placeholder="password" /*type="password"*/ value={password} onChange={(e) => setPassword(e.target.value)} required />
//                 <button type="submit">Login</button>
//             </form>

//             {loading && <p>Loading...</p>}
//             {error && <p>{error}</p>}
            
//             {bussinesDetailsForBussinesOwnerByPassword && (
//                 <div className="card" style={{ width: "20rem", marginTop: "20px" }}>
//                     <div className="card-body">
//                         <h5 className="card-title">{bussinesDetailsForBussinesOwnerByPassword.bussinesName}</h5>
//                         <p className="card-text">{bussinesDetailsForBussinesOwnerByPassword.firstNameOfOwner} {bussinesDetailsForBussinesOwnerByPassword.lastNameOfOwner}</p>
//                         <p className="card-text">{bussinesDetailsForBussinesOwnerByPassword.addressId}</p>
//                         <p className="card-text">Price range: {bussinesDetailsForBussinesOwnerByPassword.priceRange}</p>
//                         <p className="card-text">Experience: {bussinesDetailsForBussinesOwnerByPassword.experience}</p>
//                         <a href="#" className="btn btn-primary">For Information</a>
//                     </div>
//                 </div>
//             )}
//         </>
//     );
// }

// export default GetBussinesDetailsForBussinesOwnerByPassword;