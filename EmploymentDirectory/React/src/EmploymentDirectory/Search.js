// import { useState } from 'react';
// import GetBussinesDetailsForClient from './HomePage';


// function Search(){
//     var[getList, setGetList]= useState(GetBussinesDetailsForClient());

//     var [searchText, setSearchText] = useState('');

//     if(searchText === ""){
//         setSearchText(setGetList);
//         return;
//     }
//     const filterBySearch = getList.filter((item)=>{
//             if (item.toLowerCase()
//                 .includes(searchText.toLowerCase())) { return item; }
//         })
    
   


//     // const [searchVal, setSearchVal] = useState("");
//     // function handleSearchClick() {
//     //     if (searchVal === "") { setProducts(productList); return; }
//     //     const filterBySearch = productList.filter((item) => {
//     //         if (item.toLowerCase()
//     //             .includes(searchVal.toLowerCase())) { return item; }
//     //     })
//     //     setProducts(filterBySearch);

//     return(
//         <>
//             <input type="search" placeholder="search" onChange={(e) => setSearchText(e.target.value)}></input>
//             <h1>{searchText}</h1>

//             {<div class="bussinesDetails">
//         {filterBySearch.map(item => (
//           <div class="bussinesDetailsCard">
//             <div class="card-body">
//               <h3 class="card-title">{item.bussinesName}</h3>
//               <p class="card-text">{item.firstNameOfOwner} {item.lastNameOfOwner}</p>
//               <p class="card-text">{item.addressId}</p>
//               <p class="card-text">{item.priceRange}</p>
//               <p class="card-text">{item.experience}</p>
//             </div>
//           </div>
//         ))}
//       </div>}
//         </>
//     )
// }

// export default Search;