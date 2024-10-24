import React from 'react';
import styled from 'styled-components';

const HeaderContainer = styled.div`
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: white;
    padding: 10px 20px;
    border-bottom: 1px solid #e3e3e3;
`;

const Title = styled.h1`
    font-size: 24px;
    color: #333;
`;

const WarningMessage = styled.div`
    background-color: #ffdddd;
    color: #ff5b5b;
    padding: 10px 20px;
    border-radius: 20px;
    font-size: 14px;
`;

const ToggleSwitch = styled.div`
  background-color: #e0f7fa;
  border-radius: 20px;
  padding: 5px 20px;
  font-size: 16px;
  color: #00bfa5;
`;

const Header = () => {
    return (
        <HeaderContainer>
            <Title>Dashboard</Title>
            <WarningMessage>Water level is too low</WarningMessage>
            <ToggleSwitch>U</ToggleSwitch>
        </HeaderContainer>
    );
};

export default Header;
