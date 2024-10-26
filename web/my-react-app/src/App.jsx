// App.js
import React from 'react';
import Sidebar from './components/Sidebar';
import DashboardContent from './components/DashboardContent';
import Header from './components/Header';
import { AppContainer, MainContent } from './styles';

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
