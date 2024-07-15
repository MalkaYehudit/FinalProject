import React, { useState } from "react";
import axios from "axios";

function AddBusinessDetails() {
    const [bussinesDetails, setBussinesDetails] = useState({
        BussinesName: '',
        FirstName: '',
        LastName: '',
        PriceRange: '',
        Experience: '',
        AccountID: '',
    });
    const [professionName, setProfessionName] = useState('');
    const [cityName, setCityName] = useState('');
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState('');

    const handleSubmit = async (event) => {
        event.preventDefault();
        setLoading(true);

        try {
            const response = await axios.post(`http://localhost:5111/api/BussinesDetailsForBussinesOwners?cityName=${encodeURIComponent(cityName)}&professionName=${encodeURIComponent(professionName)}`, bussinesDetails);
            console.log('Response:', response.data);
            setLoading(false);
            setError('');
            // Optionally, clear the form after successful submission
            setBussinesDetails({
                BussinesName: '',
                FirstName: '',
                LastName: '',
                PriceRange: '',
                Experience: '',
                AccountID: '',
            });
            setProfessionName('');
            setCityName('');
            alert('Business details added successfully!');
        } catch (error) {
            console.error('Error adding business details:', error);
            setError('Failed to add business details');
            setLoading(false);
        }
    };

    const handleChange = (event) => {
        const { name, value } = event.target;
        if (name === 'cityName') {
            setCityName(value);
        } else if (name === 'professionName') {
            setProfessionName(value);
        } else {
            setBussinesDetails(prevState => ({
                ...prevState,
                [name]: value
            }));
        }
    };
    return (
        <div>
            <h2>Add Business Details</h2>
            <form onSubmit={handleSubmit}>
                <div>
                    <label>Bussines Name:</label>
                    <input type="text" name="BussinesName" value={bussinesDetails.BussinesName} onChange={handleChange} required />
                </div>
                <div>
                    <label>First Name:</label>
                    <input type="text" name="FirstName" value={bussinesDetails.FirstName} onChange={handleChange} required />
                </div>
                <div>
                    <label>Last Name:</label>
                    <input type="text" name="LastName" value={bussinesDetails.LastName} onChange={handleChange} required />
                </div>
                <div>
                    <label>Profession:</label>
                    <input type="text" name="professionName" value={professionName} onChange={handleChange} required />
                </div>
                <div>
                    <label>Price Range:</label>
                    <input type="text" name="PriceRange" value={bussinesDetails.PriceRange} onChange={handleChange} required />
                </div>
                <div>
                    <label>Experience:</label>
                    <input type="text" name="Experience" value={bussinesDetails.Experience} onChange={handleChange} required />
                </div>
                <div>
                    <label>City:</label>
                    <input type="text" name="cityName" value={cityName} onChange={handleChange} required />
                </div>
                <div>
                    <label>Password:</label>
                    <input type="text" name="AccountID" value={bussinesDetails.AccountID} onChange={handleChange} required />
                </div>
                <button type="submit">Add Business Details</button>
            </form>

            {loading && <p>Loading...</p>}
            {error && <p>{error}</p>}
        </div>
    );
}

export default AddBusinessDetails;
