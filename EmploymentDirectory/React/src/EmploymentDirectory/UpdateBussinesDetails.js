import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useLocation } from 'react-router-dom';

const UpdateBusinessDetails = () => {
    const [user, setUser] = useState(null); // Initialize with null or an empty object
    const [editMode, setEditMode] = useState({
        Id: false,
        BussinesName: false,
        FirstName: false,
        LastName: false,
        PriceRange: false,
        Experience: false,
        City: false,
        Profession: false,
    });

    const location = useLocation();

    useEffect(() => {
        if (location.state && location.state.userDetails) {
            setUser(location.state.userDetails);
        }
    }, [location.state]);

    const toggleEditMode = (field) => {
        setEditMode({
            ...editMode,
            [field]: !editMode[field],
        });
    };

    const handleInputChange = (e, field) => {
        setUser({
            ...user,
            [field]: e.target.value,
        });
    };

    const handleUpdate = async (field) => {
        try {
            const response = await axios.put(`http://localhost:5111/api/BussinesDetailsForBussinesOwners/${user.Id}?cityName=${encodeURIComponent(user.cityName)}&professionName=${encodeURIComponent(user.professionName)}`, {
                [field]: user[field],
            });

            if (response.status === 200) {
                toggleEditMode(field);
                console.log('User details updated successfully');
            } else {
                console.error('Failed to update user details');
            }
        } catch (error) {
            console.error('Error updating user details:', error);
        }
    };

    return (
        <div>
            {user && (
                <div>
                    <h2>User Profile</h2>
                    <p>
                        Bussines Name: {editMode.BussinesName ? (
                            <input
                                type="text"
                                value={user.BussinesName}
                                onChange={(e) => handleInputChange(e, 'BussinesName')}
                            />
                        ) : (
                            <span>{user.BussinesName}</span>
                        )}
                        <button onClick={() => handleUpdate('BussinesName')}>
                            {editMode.BussinesName ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        First Name: {editMode.FirstName ? (
                            <input
                                type="text"
                                value={user.email}
                                onChange={(e) => handleInputChange(e, 'FirstName')}
                            />
                        ) : (
                            <span>{user.FirstName}</span>
                        )}
                        <button onClick={() => handleUpdate('FirstName')}>
                            {editMode.FirstName ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Last Name: {editMode.LastName ? (
                            <input
                                type="text"
                                value={user.LastName}
                                onChange={(e) => handleInputChange(e, 'LastName')}
                            />
                        ) : (
                            <span>{user.LastName}</span>
                        )}
                        <button onClick={() => handleUpdate('LastName')}>
                            {editMode.LastName ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Price Range: {editMode.PriceRange ? (
                            <input
                                type="text"
                                value={user.PriceRange}
                                onChange={(e) => handleInputChange(e, 'PriceRange')}
                            />
                        ) : (
                            <span>{user.PriceRange}</span>
                        )}
                        <button onClick={() => handleUpdate('PriceRange')}>
                            {editMode.PriceRange ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Experience: {editMode.Experience ? (
                            <input
                                type="text"
                                value={user.Experience}
                                onChange={(e) => handleInputChange(e, 'Experience')}
                            />
                        ) : (
                            <span>{user.Experience}</span>
                        )}
                        <button onClick={() => handleUpdate('Experience')}>
                            {editMode.Experience ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        City: {editMode.City ? (
                            <input
                                type="text"
                                value={user.City}
                                onChange={(e) => handleInputChange(e, 'City')}
                            />
                        ) : (
                            <span>{user.City}</span>
                        )}
                        <button onClick={() => handleUpdate('City')}>
                            {editMode.City ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Profession: {editMode.Profession ? (
                            <input
                                type="text"
                                value={user.Profession}
                                onChange={(e) => handleInputChange(e, 'Profession')}
                            />
                        ) : (
                            <span>{user.Profession}</span>
                        )}
                        <button onClick={() => handleUpdate('Profession')}>
                            {editMode.Profession ? 'Update' : 'Change'}
                        </button>
                    </p>
                </div>
            )}
        </div>
    );
};

export default UpdateBusinessDetails;