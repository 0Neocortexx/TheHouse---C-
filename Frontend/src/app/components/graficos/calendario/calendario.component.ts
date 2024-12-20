import { Component } from '@angular/core';
import { FullCalendarModule } from '@fullcalendar/angular';
import dayGridPlugin from '@fullcalendar/daygrid';
import { CalendarOptions } from '@fullcalendar/core';
import allLocales from '@fullcalendar/core/locales-all';
import bootstrap5Plugin  from '@fullcalendar/bootstrap5';

@Component({
  selector: 'app-calendario',
  standalone: true,
  imports: [
    FullCalendarModule
  ],
  templateUrl: './calendario.component.html',
  styleUrl: './calendario.component.css'
})
export class CalendarioComponent {
  
  calendarOptions: CalendarOptions = {
    themeSystem: 'bootstrap5',
    initialView: 'dayGridMonth',
    locales: allLocales,
    locale: 'br', // the initial locale
    plugins: [dayGridPlugin, bootstrap5Plugin],
    events: [
      { title: 'Pagamento de boleto', date: '2024-11-22' },
      { title: 'event 2', date: '2019-04-02' }
    ]
  };
}
