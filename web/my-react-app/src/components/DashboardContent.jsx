// DashboardContent.js
import React from 'react';
import DashboardCard from './DashboardCard';
import SensorCard from './SensorCard';
import ElectricityConsumption from './ElectricityConsumption';
import ImageCarousel from './ImageCarousel';
import { DashboardContainer } from '../styles';

const DashboardContent = () => (
    <>
        <ImageCarousel />
        <DashboardContainer>
            <DashboardCard title="Cabbage" status="Active" imageUrl="/images/cabbage.jpg" />
            <DashboardCard title="Tomato" imageUrl="/images/tomato.jpg" />
            <DashboardCard title="Lettuce" imageUrl="/images/lettuce.jpg" />
            <DashboardCard title="Basil" imageUrl="/images/basil.jpg" />
            <DashboardCard title="Spinach" imageUrl="/images/spinach.jpg" />
            <DashboardCard title="Strawberry" imageUrl="/images/strawberry.jpg" />
            <SensorCard title="Humidity" value="72%" status="Good" />
            <SensorCard title="Temp" value="31°C" status="Moderate" />
            <SensorCard title="Water EC" value="250 μS/cm" status="Bad" />
            <SensorCard title="pH" value="7.9" status="Good" />
            <SensorCard title="Light" value="9800 lux" status="Good" />
        </DashboardContainer>
        <ElectricityConsumption />
    </>
);

export default DashboardContent;
