// DashboardCard.js
import React from 'react';
import styled from 'styled-components';

const CardContainer = styled.div`
    background-color: white;
    border-radius: 12px;
    padding: 15px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    display: flex;
    flex-direction: column;
    align-items: center;
`;

const CardImage = styled.img`
    width: 80px;
    height: 80px;
    object-fit: cover;
    border-radius: 10px;
`;

const Title = styled.h3`
    font-size: 16px;
    color: #333;
`;

const Status = styled.span`
    background-color: ${props => props.status === "Active" ? "#00e676" : "#ff5b5b"};
    color: white;
    padding: 5px 10px;
    border-radius: 15px;
    font-size: 12px;
    margin-top: 5px;
`;

const DashboardCard = ({ title, status, imageUrl }) => (
    <CardContainer>
        <CardImage src={imageUrl} alt={title} />
        <Title>{title}</Title>
        {status && <Status status={status}>{status}</Status>}
    </CardContainer>
);

export default DashboardCard;
