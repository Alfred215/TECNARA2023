import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router, RouterEvent } from '@angular/router';
import { filter } from 'rxjs';

@Component({
  selector: 'app-modal-comp',
  templateUrl: './modal-comp.component.html',
  styleUrls: ['./modal-comp.component.scss']
})
export class ModalCompComponent implements OnInit {

  @Input('path') path: string = '';
  @Input('selected') selected: boolean = false;

  currentPath: string = '';

  constructor(
    private router: Router
  ) { }

  ngOnInit() {
    this.router.events
      .pipe()
      .subscribe(() => {
        this.comprobarRuta();
      });
  }

  comprobarRuta() {
    
    const rutaActual = this.router.url;
    const etiqueta1 = document.getElementById('persons-link') as HTMLElement;;
    const etiqueta2 = document.getElementById('clients-link') as HTMLElement;;

    if (rutaActual === '/persona') etiqueta1.style.color = '#ffcc00';
    if (rutaActual === '/cliente/list') etiqueta2.style.color = '#ffcc00'; 
    
  }
}
