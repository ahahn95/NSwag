import React from 'react';
import {useGetAllCars} from "./hooks/cars/carHooks";
import {CarRequest} from "./client";

export const App = () => {
    const [cars, refresh] = useGetAllCars();
    
    console.log(cars);
    
    const handleSubmit = async (event: any) => {
        event.preventDefault()
        const values = new FormData(event.target);
        
        const car: CarRequest = {
            
        }
    }
    
    return <div>
            <form onSubmit={handleSubmit}>
                <label htmlFor={"make"}>Make</label>
                <input id={"make"} name={"make"} />
                <label htmlFor={"model"}>model</label>
                <input id={"model"} name={"model"} />
                <button type={"submit"}>Submit</button>
            </form>
        <button type={"button"} onClick={refresh}>Update</button>
            </div>;
}

