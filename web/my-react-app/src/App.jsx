import React from 'react';
import Sidebar from './components/Sidebar';
import DashboardContent from './components/DashboardContent';
import Header from './components/Header';
import styled from 'styled-components';

const AppContainer = styled.div`
    display: grid;
    grid-template-columns: 250px 1fr;
    height: 100vh;
`;

const MainContent = styled.div`
    background-color: #f7f8fa;
    padding: 20px;
`;

function App() {
    return (
        <AppContainer>
            <Sidebar />
            <MainContent>
                <Header />
                <DashboardContent />
            </MainContent>
        </AppContainer>
    );
}

export default App;
