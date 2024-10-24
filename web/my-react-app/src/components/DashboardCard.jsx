import React from 'react';
import styled from 'styled-components';

const CardContainer = styled.div`
  background-color: white;
  border-radius: 12px;
  padding: 20px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  display: flex;
  flex-direction: column;
  align-items: center;
`;

const CardImage = styled.img`
  width: 100px;
  height: 100px;
  object-fit: cover;
  border-radius: 12px;
`;

const Title = styled.h2`
  font-size: 18px;
  margin: 10px 0;
  color: #333;
`;

const Status = styled.span`
  background-color: #00e676;
  color: white;
  padding: 5px 10px;
  border-radius: 20px;
  font-size: 12px;
  margin-top: 5px;
`;

const DashboardCard = ({ title, status, imageUrl }) => {
    return (
        <CardContainer>
            <CardImage src={imageUrl} alt={title} />
            <Title>{title}</Title>
            {status && <Status>{status}</Status>}
        </CardContainer>
    );
};

export default DashboardCard;
