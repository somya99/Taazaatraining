import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { IUser } from './IUser';
import { Login } from './Login';

function ageRangeValidator(min : number, max : number) : ValidatorFn
{
  return (control : AbstractControl) : {[key : string] : boolean} | null =>
  {
    if(control.value !== undefined && (isNaN(control.value) || control.value < min || control.value > max) ){
      return {'ageRange' : true};
    }
    return null;
  };
}

// function ageRangeValidator(control  :AbstractControl) : {[key : string] : boolean} | null{
//   if(control.value !== undefined && (isNaN(control.value) || control.value < 18 || control.value > 45) ){
//     return {'ageRange' : true};
//   }
//   return null;
// }

@Component({
  selector: 'app-loginform',
  templateUrl: './loginform.component.html',
  styleUrls: ['./loginform.component.css']
})
export class LoginformComponent implements OnInit {

  loginForm : FormGroup;
  min = 30;
  max = 70;
  user : IUser = {
    email : "somya.das@taazaa.com",
    password : "123456789"
  }

  model: Login;
  constructor() {
    this.model = new Login("abc@gmail.com", "12345678");
  }
  onSubmit(loginform) {
    console.log(loginform.value);
    console.log(loginform.status);
  }
  newLogin() {
    this.model = new Login(null, null);
  }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      email : new FormControl(null,[Validators.required]),
      password : new FormControl(null,[Validators.required,Validators.minLength(5)]),
      age  : new FormControl(null, [ageRangeValidator(this.min, this.max)]),
      phonenumber : new FormControl(null, []),
      notification : new FormControl('email', [])
    });
    this.formControlValueChanged();
  }

  login(){
    console.log(this.loginForm.value);
    console.log(this.user);
  }

  cancel(){
    this.loginForm.reset();
  }

  formControlValueChanged(){
    const phoneControl = this.loginForm?.get('phonenumber');
    this.loginForm.get('notification')?.valueChanges.subscribe((data : string) =>{
      console.log(data);
      if(data === 'phone'){
        phoneControl?.setValidators([Validators.required])
      }
      else if(data === 'email'){
        phoneControl.clearValidators();
      }
      phoneControl?.updateValueAndValidity();
    })
  }
}
