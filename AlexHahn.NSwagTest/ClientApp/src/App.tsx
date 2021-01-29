import React from 'react';
import {useCreateCar, useGetAllCars} from "./hooks/cars/carHooks";
import {CarRequest} from "./client";

export const App = () => {
    const [cars, refresh] = useGetAllCars();
    const [createCar] = useCreateCar();

    const handleSubmit = async (event: any) => {
        event.preventDefault()
        const values = new FormData(event.target);

        const car: CarRequest = {
            make: values.get("make")?.toString() || '',
            model: values.get("model")?.toString() || '',
        }

        await createCar(car);
        await refresh();
    }

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <label htmlFor={"make"}>Make</label>
                <input id={"make"} name={"make"}/>
                <label htmlFor={"model"}>model</label>
                <input id={"model"} name={"model"}/>
                <button type={"submit"}>Submit</button>
            </form>
            <ul>
                {cars.map(car => <li key={car.id}>{car.make} {car.model}</li>)}
            </ul>
        </div>);
}

