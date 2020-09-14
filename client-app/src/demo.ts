let data:number|string ;
data="50";
const car1:ICar={
    color:'blue',
    model:'BMW',
    
}
const car2:ICar={
    color:'red',
    model:'benz',
topspeed:100
}
export interface ICar {
    color:string,
    model:string,
    topspeed ?:number
}
export const cars=[car1,car2];
const mutiply=(x:number,y:number)=>{
     return (x*y);
}