import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useLocation } from 'react-router-dom';

const UpdateBusinessDetails = () => {
    const [user, setUser] = useState(null);
    const [editMode, setEditMode] = useState({
        Id: false,
        bussinesName: false,
        firstNameOfOwner: false,
        lastNameOfOwner: false,
        priceRange: false,
        experience: false,
        city: false,
        profession: false,
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
            const data = {
                [field]: user[field], // Dynamically set the field to update
            };
            const response = await axios.put(`http://localhost:5111/api/BussinesDetailsForBussinesOwners/${user.Id}?cityName=${encodeURIComponent(user.city)}&professionName=${encodeURIComponent(user.profession)}`, data,
                {
                    headers: {
                        'Content-Type': 'application/json', // Ensure correct content type
                    },
                }
            );

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
                        Bussines Name: {editMode.bussinesName ? (
                            <input
                                type="text"
                                value={user.bussinesName}
                                onChange={(e) => handleInputChange(e, 'bussinesName')}
                            />
                        ) : (
                            <span>{user.bussinesName}</span>
                        )}
                        <button onClick={() => handleUpdate('bussinesName')}>
                            {editMode.bussinesName ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        First Name: {editMode.firstName ? (
                            <input
                                type="text"
                                value={user.firstName}
                                onChange={(e) => handleInputChange(e, 'firstName')}
                            />
                        ) : (
                            <span>{user.firstName}</span>
                        )}
                        <button onClick={() => handleUpdate('firstName')}>
                            {editMode.firstName ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Last Name: {editMode.lastName ? (
                            <input
                                type="text"
                                value={user.lastName}
                                onChange={(e) => handleInputChange(e, 'lastName')}
                            />
                        ) : (
                            <span>{user.lastName}</span>
                        )}
                        <button onClick={() => handleUpdate('lastName')}>
                            {editMode.lastName ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Price Range: {editMode.priceRange ? (
                            <input
                                type="text"
                                value={user.priceRange}
                                onChange={(e) => handleInputChange(e, 'priceRange')}
                            />
                        ) : (
                            <span>{user.priceRange}</span>
                        )}
                        <button onClick={() => handleUpdate('priceRange')}>
                            {editMode.priceRange ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Experience: {editMode.experience ? (
                            <input
                                type="text"
                                value={user.experience}
                                onChange={(e) => handleInputChange(e, 'experience')}
                            />
                        ) : (
                            <span>{user.experience}</span>
                        )}
                        <button onClick={() => handleUpdate('experience')}>
                            {editMode.experience ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        City: {editMode.city ? (
                            <input
                                type="text"
                                value={user.city}
                                onChange={(e) => handleInputChange(e, 'city')}
                            />
                        ) : (
                            <span>{user.city}</span>
                        )}
                        <button onClick={() => handleUpdate('city')}>
                            {editMode.city ? 'Update' : 'Change'}
                        </button>
                    </p>
                    <p>
                        Profession: {editMode.profession ? (
                            <input
                                type="text"
                                value={user.profession}
                                onChange={(e) => handleInputChange(e, 'profession')}
                            />
                        ) : (
                            <span>{user.profession}</span>
                        )}
                        <button onClick={() => handleUpdate('profession')}>
                            {editMode.profession ? 'Update' : 'Change'}
                        </button>
                    </p>
                </div>
            )}
        </div>
    );
};

export default UpdateBusinessDetails;