import {useEffect, useState} from 'react';
import {CarResponse, CarApiClient, CarRequest} from "../../client";

const client = new CarApiClient();

export function useGetAllCars() {
    const [cars, setCars] = useState<CarResponse[]>([]);

    async function getAllCars() {
        const response = await client.getAll();
        setCars(response);
    }

    useEffect(() => {
        getAllCars();
    }, [])

    return [cars, getAllCars] as const;
}


export function useCreateCar() {
    async function createCar(car: CarRequest) {
        return await client.create(car);
    }
    return [createCar]
}