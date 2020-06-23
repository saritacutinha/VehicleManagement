import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../services/vehicle-service';




@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[] = new Array();
  types: any[] = new Array();
  models: any[] = new Array();
  vehicle: any = {};

  constructor(private vehicleService: VehicleService) { }

  ngOnInit(): void {
    this.vehicleService.getMakes().subscribe((makes: []) => this.makes = makes);
    this.vehicleService.getVehicleTypes().subscribe((types: []) => {
      this.types = types; console.log("Type:",this.types)
    });
  }
  onMakeChange() {
    var selectedMake = this.makes.find(m => m.id == this.vehicle.makeId)
    this.models = selectedMake ? selectedMake.models : [];
    delete this.vehicle.modelId;
  }
  submit() {
    this.vehicleService.create(this.vehicle).subscribe(x => console.log(x));
  }
}
