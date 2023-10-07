import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.scss']
})
export class SelectComponent {
  @Input() label!: string;
  @Output() onChange: EventEmitter<Event> = new EventEmitter();

  handleOnChange(event: Event) {
    this.onChange.emit(event);
  }
}