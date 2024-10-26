import React from 'react';
import Slider from 'react-slick';
import styled from 'styled-components';
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

const CarouselContainer = styled.div`
    margin-top: 20px;
    border-radius: 10px;
    overflow: hidden;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
`;

const Image = styled.img`
    width: 100%;
    height: 200px;
    object-fit: cover;
`;

const ImageCarousel = () => {
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
    };

    const images = [
        "/images/cabbage-field.jpg",
        "/images/lettuce-field.jpg",
        "/images/strawberry-field.jpg"
    ];

    return (
        <CarouselContainer>
            <Slider {...settings}>
                {images.map((src, index) => (
                    <Image key={index} src={src} alt={`Field ${index + 1}`} />
                ))}
            </Slider>
        </CarouselContainer>
    );
};

export default ImageCarousel;
