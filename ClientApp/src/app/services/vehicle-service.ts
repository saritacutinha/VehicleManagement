import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  constructor(private http: HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }  
  getMakes() {
    return this.http.get('/api/makes');             
  }
  getVehicleTypes() {
    return this.http.get('/api/vehicleTypes');
  }
  create(vehicle) {
    
    return this.http.post('/api/vehicles',vehicle);
  }

}
