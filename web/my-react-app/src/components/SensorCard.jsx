// SensorCard.jsx
import React from 'react';
import styled from 'styled-components';
import { Thermostat, WaterDrop, Opacity, LightMode, Science } from '@mui/icons-material';

// Define CardContainer directly in this file
const CardContainer = styled.div`
    background-color: white;
    border-radius: 12px;
    padding: 15px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    display: flex;
    flex-direction: column;
    align-items: center;
`;

const IconWrapper = styled.div`
    margin-bottom: 10px;
    color: #888;
    font-size: 30px;
`;

const CardTitle = styled.h3`
    font-size: 16px;
    color: #333;
`;

const CardValue = styled.p`
    font-size: 24px;
    color: #555;
`;

const CardStatus = styled.span`
    background-color: ${props =>
    props.status === 'Good' ? '#00e676' :
        props.status === 'Moderate' ? '#ffcc00' :
            '#ff5b5b'};
    color: white;
    padding: 5px 10px;
    border-radius: 10px;
    font-size: 12px;
    margin-top: 5px;
`;

// Determine the icon based on the title
const getIcon = (title) => {
    switch(title) {
        case "Humidity": return <Opacity />;
        case "Temp": return <Thermostat />;
        case "Water EC": return <Science />;
        case "pH": return <WaterDrop />;
        case "Light": return <LightMode />;
        default: return null;
    }
};

const SensorCard = ({ title, value, status }) => (
    <CardContainer>
        <IconWrapper>{getIcon(title)}</IconWrapper>
        <CardTitle>{title}</CardTitle>
        <CardValue>{value}</CardValue>
        <CardStatus status={status}>{status}</CardStatus>
    </CardContainer>
);

export default SensorCard;
