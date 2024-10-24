import React from "react";
import styled from "styled-components";
import { AreaChart, Area, XAxis, YAxis, Tooltip, ResponsiveContainer } from "recharts";

const data = [
    { name: "Jan", consumption: 30 },
    { name: "Feb", consumption: 20 },
    { name: "Mar", consumption: 48.3 },
    { name: "Apr", consumption: 25 },
    { name: "May", consumption: 60 },
    { name: "Jun", consumption: 35 },
];

const DashboardContainer = styled.div`
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 20px;
  margin-top: 20px;
`;

const Card = styled.div`
  background-color: white;
  padding: 20px;
  border-radius: 10px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
`;

const ChartContainer = styled.div`
  grid-column: span 3;
`;

const Dashboard = () => {
    return (
        <DashboardContainer>
            <Card>
                <h3>Cabbage</h3>
                <p>Humidity: 72%</p>
            </Card>
            <Card>
                <h3>Tomato</h3>
                <p>Temperature: 31°C</p>
            </Card>
            <Card>
                <h3>Electricity Consumption</h3>
                <ChartContainer>
                    <ResponsiveContainer width="100%" height={200}>
                        <AreaChart data={data}>
                            <XAxis dataKey="name" />
                            <YAxis />
                            <Tooltip />
                            <Area type="monotone" dataKey="consumption" stroke="#8884d8" fill="#8884d8" />
                        </AreaChart>
                    </ResponsiveContainer>
                </ChartContainer>
            </Card>
        </DashboardContainer>
    );
};

export default Dashboard;
