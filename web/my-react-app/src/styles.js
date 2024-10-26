// styles.js - Global styles and layout configurations

import styled from 'styled-components';

export const AppContainer = styled.div`
    display: grid;
    grid-template-columns: 80px 1fr;
    height: 100vh; 
    overflow: hidden; 
`;

export const SidebarContainer = styled.div`
    background-color: #edf5f7;
    padding: 10px;
    display: flex;
    flex-direction: column;
    align-items: center;
    height: 100%; 
    overflow: hidden; 
`;

export const MainContent = styled.div`
    background-color: #f7f8fa;
    padding: 20px;
    overflow-y: auto; 
    height: 100vh; 
`;

export const IconButton = styled.div`
    margin: 15px 0;
    width: 50px;
    height: 50px;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: white;
    border-radius: 15px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
    cursor: pointer;
`;

export const HeaderContainer = styled.div`
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 15px 20px;
    background-color: white;
    border-bottom: 1px solid #e3e3e3;
`;

export const Title = styled.h1`
    font-size: 24px;
    color: #333;
`;

export const WarningMessage = styled.div`
    background-color: #ffdddd;
    color: #ff5b5b;
    padding: 8px 15px;
    border-radius: 20px;
    font-size: 14px;
`;

export const ToggleSwitch = styled.div`
    background-color: #e0f7fa;
    padding: 5px 15px;
    border-radius: 20px;
    color: #00bfa5;
    font-size: 14px;
    font-weight: bold;
`;

export const DashboardContainer = styled.div`
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
    margin-top: 20px;
`;
