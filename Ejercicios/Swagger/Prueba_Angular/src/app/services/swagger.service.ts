import { EventEmitter, OnDestroy } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { timeout, retry, catchError, map, Observable, throwError } from "rxjs";

const REQUEST_ERROR_TIMEOUT_MS = 10000;
const REQUEST_ERROR_RETRY = 2;
const ERROR_TOAST_DURATION_MS = 10000;
export class Swagger {
  private _baseUrl = 'https://localhost:7152';
  private errorSubscriber = new EventEmitter<string>();

  constructor(
    public httpClient: HttpClient,
  ) {}

  getPersonas() {
    return this.httpClient.get(`${this._baseUrl}/Person/GetListPerson`)
      .pipe(
        timeout(REQUEST_ERROR_TIMEOUT_MS),
        retry(REQUEST_ERROR_RETRY),
        catchError((err, caught) => this.handleApiError(err, caught)),
        map((input: any) => {
        // const asObject: CourseListRESULT<CourseListDATOS> = JSON.parse(input);
        return input;
        })
      );
  }

  private handleApiError(err: any, caught: Observable<Object>) {
    this.errorSubscriber.next('');
    return throwError(err);
  }
}
