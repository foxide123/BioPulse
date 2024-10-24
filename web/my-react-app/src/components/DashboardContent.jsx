import React from 'react';
import styled from 'styled-components';
import DashboardCard from './DashboardCard';
import ElectricityConsumption from './ElectricityConsumption';

const DashboardContainer = styled.div`
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-gap: 20px;
  margin-top: 20px;
`;

const DashboardContent = () => {
    return (
        <>
            <DashboardContainer>
                <DashboardCard title="Cabbage" status="Active" imageUrl="/images/cabbage.jpg" />
                <DashboardCard title="Tomato" imageUrl="/images/tomato.jpg" />
                <DashboardCard title="Lettuce" imageUrl="/images/lettuce.jpg" />
                <DashboardCard title="Basil" imageUrl="/images/basil.jpg" />
                <DashboardCard title="Spinach" imageUrl="/images/spinach.jpg" />
                <DashboardCard title="Strawberry" imageUrl="/images/strawberry.jpg" />
            </DashboardContainer>
            <ElectricityConsumption />
        </>
    );
};

export default DashboardContent;
