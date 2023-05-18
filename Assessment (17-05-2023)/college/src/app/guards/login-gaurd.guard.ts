import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, CanLoad, Route, Router, RouterStateSnapshot, UrlSegment, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { CollegeServiceService } from '../services/college-service.service';

@Injectable({
  providedIn: 'root'
})
export class LoginGaurdGuard implements CanActivate, CanLoad {
  constructor(private apiService:CollegeServiceService,private route:Router){}
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    return localStorage.getItem("role")=="admin"? true: this.login();
  }
  canLoad(
    route: Route,
    segments: UrlSegment[]): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      return localStorage.getItem("role")=="admin"? true : this.route.navigate(['/login']);
  }

  login(){
    this.route.navigate(['/login']).then(() => {
      window.location.reload();
    });;
    return false;
  }
}
