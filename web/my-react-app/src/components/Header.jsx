// Header.js
import React from 'react';
import { HeaderContainer, Title, WarningMessage, ToggleSwitch } from '../styles';

const Header = () => (
    <HeaderContainer>
        <Title>Dashboard</Title>
        <WarningMessage>Water level is too low</WarningMessage>
        <ToggleSwitch>U</ToggleSwitch>
    </HeaderContainer>
);

export default Header;
