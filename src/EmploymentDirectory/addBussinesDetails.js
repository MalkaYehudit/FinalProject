// import React from "react";
// import axios from "axios";

// function AddNewBussines() {
//    axios.post('http://localhost:5111/api/BussinesDetailsForBussinesOwners')
//    .then(res => {
//     const bussinesDetailsForBussinesOwner = res.data;
//     console.log(bussinesDetailsForBussinesOwner);
//   })
// //   axios.get('http://localhost:5111/api/BussinesDetailsForBussinesOwners')
// //    .then(res => {
// //     const bussinesDetailsForBussinesOwner = res.data;
// //     console.log(bussinesDetailsForBussinesOwner);
// //   })
// //   .catch(error => {
// //     console.error(error);
// //   });

// //   return (
// //     <>
      
// //     </>
// //   );  
// }

import React from 'react';
import axios from 'axios';

function AddNewBussines() {
    axios.post('http://localhost:5111/api/BussinesDetailsForBussinesOwners')
   .then(res => {
    const bussinesDetailsForBussinesOwner = res.data;
    console.log(bussinesDetailsForBussinesOwner);
  })
}
// export default class PersonAdd extends React.Component {
//   state = {
//     name: ''
//   }

//   handleChange = event => {
//     this.setState({ name: event.target.value });
//   }

//   handleSubmit = event => {
//     event.preventDefault();

//     const user = {
//       name: this.state.name
//     };

//     axios.post(`https://jsonplaceholder.typicode.com/users`, { user })
//       .then(res => {
//         console.log(res);
//         console.log(res.data);
//       })
//   }

//   render() {
//     return (
//       <div>
//         <form onSubmit={this.handleSubmit}>
//           <label>
//             Person Name:
//             <input type="text" name="name" onChange={this.handleChange} />
//           </label>
//           <button type="submit">Add</button>
//         </form>
//       </div>
//     )
//   }
// }