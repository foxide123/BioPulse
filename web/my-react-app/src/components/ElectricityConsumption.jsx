import React from 'react';
import { AreaChart, Area, XAxis, YAxis, Tooltip, ResponsiveContainer } from 'recharts';
import styled from 'styled-components';

const data = [
    { name: 'Jan', consumption: 30 },
    { name: 'Feb', consumption: 20 },
    { name: 'Mar', consumption: 48.3 },
    { name: 'Apr', consumption: 25 },
    { name: 'May', consumption: 60 },
    { name: 'Jun', consumption: 35 },
];

const ChartContainer = styled.div`
  margin-top: 20px;
  background-color: white;
  padding: 20px;
  border-radius: 12px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  grid-column: span 3;
`;

const ElectricityConsumption = () => {
    return (
        <ChartContainer>
            <h3>Electricity Consumption</h3>
            <ResponsiveContainer width="100%" height={200}>
                <AreaChart data={data}>
                    <XAxis dataKey="name" />
                    <YAxis />
                    <Tooltip />
                    <Area type="monotone" dataKey="consumption" stroke="#8884d8" fill="#8884d8" />
                </AreaChart>
            </ResponsiveContainer>
        </ChartContainer>
    );
};

export default ElectricityConsumption;
