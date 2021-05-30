import { Installment } from "./Installment";

export class Debit {
  Penalty!: string;
  Interest!: string;
  Installments!: Installment[];
}
